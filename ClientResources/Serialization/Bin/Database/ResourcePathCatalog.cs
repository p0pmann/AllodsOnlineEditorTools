namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

public sealed record PathRecoveryReport(string Database, int Restored, int Unmatched, int AmbiguousIds, int TypeMismatches, int PathConflicts, int InvalidPaths,
    int PayloadMatches = 0);

/// <summary>Recovers older resource names through resource IDs and catalogued pak payload paths.</summary>
public sealed partial class ResourcePathCatalog
{
    private sealed record Entry(string Path, string Type);
    private sealed record Plan(DatabaseMetadata Target, Dictionary<long, string> Paths, PathRecoveryReport Report);
    private readonly Dictionary<string, Dictionary<int, Entry?>> _databases = new(StringComparer.OrdinalIgnoreCase);
    private readonly Dictionary<string, Dictionary<string, Entry?>> _paths = new(StringComparer.OrdinalIgnoreCase);

    public ResourcePathCatalog(IReadOnlyDictionary<string, DatabaseMetadata> references)
    {
        foreach (var (databaseName, metadata) in references)
        {
            var entries = new Dictionary<int, Entry?>();
            var paths = new Dictionary<string, Entry?>(StringComparer.OrdinalIgnoreCase);
            foreach (var (offset, path) in metadata.DbId2File)
            {
                if (string.IsNullOrWhiteSpace(path) || !IsRoot(metadata, offset) || metadata.GetStructType(offset) is not { } type)
                {
                    continue;
                }

                var entry = new Entry(path.Replace('\\', '/'), type);
                if (!paths.TryAdd(entry.Path, entry) && paths[entry.Path] != entry)
                {
                    paths[entry.Path] = null;
                }

                if (!metadata.DbId2ResId.TryGetValue(offset, out var id) || id == 0)
                {
                    continue;
                }

                if (!entries.TryAdd(id, entry) && entries[id] != entry)
                {
                    entries[id] = null;
                }
            }
            _databases.Add(databaseName, entries);
            _paths.Add(databaseName, paths);
        }
    }

    public PathRecoveryReport RestoreMissingPaths(DatabaseMetadata target, string databaseName)
        => RestoreMissingPaths(new Dictionary<string, DatabaseMetadata> { [databaseName] = target }).Single();

    public IReadOnlyList<PathRecoveryReport> RestoreMissingPaths(IReadOnlyDictionary<string, DatabaseMetadata> targets)
    {
        var plans = targets.Select(p => PlanMissingPaths(p.Value, p.Key)).ToArray();
        return ApplyPlans(targets, plans);
    }

    private static IReadOnlyList<PathRecoveryReport> ApplyPlans(IReadOnlyDictionary<string, DatabaseMetadata> targets, Plan[] plans)
    {
        // XDB and JDB replace the extension, and Windows also aliases names that differ only by case.
        var claimed = targets.Values.SelectMany(m => m.DbId2File.Values).Where(p => !string.IsNullOrWhiteSpace(p))
            .Select(OutputKey).ToHashSet(StringComparer.OrdinalIgnoreCase);
        var counts = plans.SelectMany(p => p.Paths.Values).CountBy(OutputKey, StringComparer.OrdinalIgnoreCase).ToDictionary(StringComparer.OrdinalIgnoreCase);
        var reports = new List<PathRecoveryReport>();
        foreach (var plan in plans)
        {
            var target = plan.Target;
            int restored = 0, conflicts = 0;
            foreach (var (offset, path) in plan.Paths)
            {
                if (claimed.Contains(OutputKey(path)) || counts[OutputKey(path)] != 1 || target.File2DbId.ContainsKey(path))
                { conflicts++; continue; }
                DatabaseExport.AssignPath(target, offset, path);
                restored++;
            }
            reports.Add(plan.Report with { Restored = plan.Report.Restored + restored, PathConflicts = plan.Report.PathConflicts + conflicts });
        }
        return reports;
    }

    private Plan PlanMissingPaths(DatabaseMetadata target, string databaseName)
    {
        var roots = target.Fixes.Where(p => p.Value.Type == PointerFix.FixType.Type).Select(p => p.Key).ToArray();
        var ids = new Dictionary<int, int>();
        foreach (var offset in roots)
        {
            if (target.DbId2ResId.TryGetValue(offset, out var id) && id != 0)
            {
                ids[id] = ids.GetValueOrDefault(id) + 1;
            }
        }

        _databases.TryGetValue(databaseName, out var entries);
        var plan = new Dictionary<long, string>();
        int unmatched = 0, ambiguous = 0, mismatched = 0, invalid = 0;
        foreach (var offset in roots)
        {
            if (target.DbId2File.TryGetValue(offset, out var existing) && !string.IsNullOrWhiteSpace(existing))
            {
                continue;
            }

            if (!target.DbId2ResId.TryGetValue(offset, out var id) || id == 0 || entries == null || !entries.TryGetValue(id, out var entry))
            { unmatched++; continue; }
            if (entry == null || ids[id] != 1)
            { ambiguous++; continue; }
            if (!string.Equals(entry.Type, target.GetStructType(offset), StringComparison.Ordinal))
            { mismatched++; continue; }
            if (!IsRelativeResourcePath(entry.Path))
            { invalid++; continue; }
            plan.Add(offset, entry.Path);
        }

        return new(target, plan, new(databaseName, 0, unmatched, ambiguous, mismatched, 0, invalid));
    }

    private static bool IsRoot(DatabaseMetadata metadata, long offset) => metadata.Fixes.TryGetValue(offset, out var fix) && fix.Type == PointerFix.FixType.Type;
    private static string OutputKey(string path) => Path.ChangeExtension(path.Replace('\\', '/'), ".xdb");
    private static bool IsRelativeResourcePath(string path)
    {
        if (path.Length == 0 || path.Any(c => c < 32 || ":*?\"<>|".Contains(c)))
        {
            return false;
        }

        return path.Split('/').All(part => part.Length != 0 && part is not "." and not ".." && part == part.TrimEnd(' ', '.'));
    }
}

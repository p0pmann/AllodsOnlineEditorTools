using System.Buffers.Binary;
using AllodsOnlineEditorTools.ClientResources.DataTypes;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

public sealed partial class ResourcePathCatalog
{
    public IReadOnlyList<PathRecoveryReport> RestoreMissingPaths(IReadOnlyDictionary<string, BinDatabase> targets, PacksRegistry? packs, StructTypeResolver resolver)
    {
        var metadata = targets.ToDictionary(p => p.Key, p => p.Value.Metadata);
        var reports = RestoreMissingPaths(metadata);
        if (packs == null)
        {
            return reports;
        }

        var previous = reports.ToDictionary(r => r.Database);
        var fileOffsets = resolver.ByName.ToDictionary(p => p.Key,
            p => StructModelCache.Get(p.Value).Fields.Where(f => f.FieldType == typeof(FileRef) && f.Offset.HasValue)
                .Select(f => (long)f.Offset!.Value).ToHashSet());
        var plans = targets.Select(p => PlanPayloadPaths(p.Value, p.Key, packs, fileOffsets, previous[p.Key])).ToArray();
        return ApplyPlans(metadata, plans).Select(r => r with { PayloadMatches = r.Restored - previous[r.Database].Restored }).ToArray();
    }

    private Plan PlanPayloadPaths(BinDatabase database, string name, PacksRegistry packs, IReadOnlyDictionary<string, HashSet<long>> fileOffsets,
        PathRecoveryReport report)
    {
        var metadata = database.Metadata;
        var plan = new Dictionary<long, string>();
        if (!_paths.TryGetValue(name, out var knownPaths) || metadata.Packs == null || metadata.PakFileRefOffsets == null)
        {
            return new(metadata, plan, report);
        }

        var roots = metadata.Fixes.Where(p => p.Value.Type == PointerFix.FixType.Type).Select(p => p.Key).Order().ToArray();
        var candidates = new Dictionary<long, HashSet<string>>();
        foreach (var offset in metadata.PakFileRefOffsets)
        {
            if (offset < 0 || offset > database.Data.Length - 5 * metadata.PointerSize)
            {
                continue;
            }

            var packIndex = Word(offset + 3 * metadata.PointerSize);
            var entryIndex = Word(offset + 4 * metadata.PointerSize);
            if (packIndex < 0 || packIndex >= metadata.Packs.Count || entryIndex < 0 || entryIndex > int.MaxValue ||
                !packs.TryGetFilename(metadata.Packs[(int)packIndex], (int)entryIndex, out var payload))
            {
                continue;
            }

            var path = payload.Replace('\\', '/').TrimStart('/');
            if (path.EndsWith(".hi.bin", StringComparison.OrdinalIgnoreCase))
            {
                path = path[..^7] + ".bin";
            }

            path = Path.ChangeExtension(path, ".xdb");
            // The descriptor must actually exist in the reference catalog; a payload stem alone is not a recovered name.
            if (!knownPaths.TryGetValue(path, out var source) || source == null || !IsRelativeResourcePath(source.Path))
            {
                continue;
            }

            var index = Array.BinarySearch(roots, (long)offset);
            if (index < 0)
            {
                index = ~index - 1;
            }

            if (index < 0)
            {
                continue;
            }

            var root = roots[index];
            if (metadata.DbId2File.TryGetValue(root, out var current) && !string.IsNullOrWhiteSpace(current))
            {
                continue;
            }
            // Do not override a rejected ID match with weaker payload evidence.
            if (metadata.DbId2ResId.TryGetValue(root, out var id) && id != 0 && _databases[name].ContainsKey(id))
            {
                continue;
            }

            if (metadata.GetStructType(root) != source.Type)
            {
                continue;
            }

            // Memory order alone does not prove ownership, particularly for separately allocated array contents.
            if (!fileOffsets.TryGetValue(source.Type, out var offsets) || !offsets.Contains(offset - root))
            {
                continue;
            }

            if (!candidates.TryGetValue(root, out var paths))
            {
                candidates[root] = paths = new(StringComparer.OrdinalIgnoreCase);
            }

            paths.Add(source.Path);
        }
        var conflicts = 0;
        foreach (var (root, paths) in candidates)
        {
            if (paths.Count == 1)
            {
                plan.Add(root, paths.Single());
            }
            else
            {
                conflicts++;
            }
        }
        return new(metadata, plan, report with { Unmatched = report.Unmatched - candidates.Count, PathConflicts = report.PathConflicts + conflicts });

        long Word(int offset) => metadata.PointerSize switch
        {
            4 => BinaryPrimitives.ReadInt32LittleEndian(database.Data.AsSpan(offset, 4)),
            8 => BinaryPrimitives.ReadInt64LittleEndian(database.Data.AsSpan(offset, 8)),
            _ => throw new InvalidDataException("Unsupported pointer size in resource path recovery"),
        };
    }
}

using System.Buffers.Binary;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

public static class DatabaseExport
{
    /// <summary>Give remaining unnamed roots export identities after any reference paths have been restored.</summary>
    public static void AssignMissingPaths(BinDatabase database, string databaseName)
    {
        var metadata = database.Metadata;
        var stem = Path.GetFileNameWithoutExtension(databaseName);
        foreach (var (offset, fix) in metadata.Fixes)
        {
            if (fix.Type != PointerFix.FixType.Type || metadata.DbId2File.TryGetValue(offset, out var existing) && !string.IsNullOrWhiteSpace(existing))
            {
                continue;
            }

            var identity = metadata.DbId2ObjId?.TryGetValue(offset, out var id) == true ? $"obj-{id}" : $"offset-{offset}";
            var path = $"__generated/{stem}/{identity}.xdb";
            if (metadata.File2DbId.ContainsKey(path))
            {
                throw new InvalidDataException($"Generated path collision: {path}");
            }

            AssignPath(metadata, offset, path);
        }
    }

    internal static void AssignPath(DatabaseMetadata metadata, long offset, string path)
    {
        if (metadata.DbId2File.TryGetValue(offset, out var previous) && metadata.File2DbId.TryGetValue(previous, out var owner) && owner == offset)
        {
            metadata.File2DbId.Remove(previous);
        }

        metadata.DbId2File[offset] = path;
        metadata.File2DbId.Add(path, offset);
    }

    public static IReadOnlyList<long?> ReadLocalizedResources(BinDatabase database, StructTypeResolver resolver)
    {
        var metadata = database.Metadata;
        var root = metadata.Fixes.Where(p => p.Value.Type == PointerFix.FixType.Type && metadata.GetStructType(p.Key) == "LocalizedResources")
            .Select(p => p.Key).Single();
        var model = StructModelCache.Get(resolver.ResolveByName("LocalizedResources"));
        var field = model.Fields.Single(f => f.Name == "resources");
        if (metadata.PointerSize != 8 || field.Offset is not { } fieldOffset || field.ArrayStride != 8)
        {
            throw new InvalidDataException("Unsupported LocalizedResources layout");
        }

        var offset = root + fieldOffset;
        var length = BinaryPrimitives.ReadInt64LittleEndian(database.Data.AsSpan(checked((int)offset + 8), 8));
        if (length < 0 || length % 8 != 0 || length > database.Data.Length)
        {
            throw new InvalidDataException("Invalid localized resource vector length");
        }

        if (length == 0)
        {
            return [];
        }

        if (!metadata.Fixes.TryGetValue(offset, out var vector) || vector.Type != PointerFix.FixType.Direct ||
            vector.Value < 0 || vector.Value > database.Data.Length - length)
        {
            throw new InvalidDataException("Invalid localized resource vector relocation");
        }

        var result = new long?[checked((int)(length / 8))];
        for (var i = 0; i < result.Length; i++)
        {
            if (!metadata.Fixes.TryGetValue(vector.Value + i * 8, out var fix))
            {
                continue;
            }

            if (fix.Type != PointerFix.FixType.DbIdRef || fix.External)
            {
                throw new InvalidDataException("LocalizedResources entry does not point into its own database");
            }

            result[i] = fix.Value;
        }
        return result;
    }
}

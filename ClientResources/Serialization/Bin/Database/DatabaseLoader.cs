using System.IO.Compression;
using AllodsOnlineEditorTools.ClientResources.Structs;
using Microsoft.Extensions.Logging;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

public static class DatabaseLoader
{
    public static Dictionary<string, BinDatabase> LoadDatabases(string binPath, ILoggerFactory loggerFactory)
        => Load(binPath, loggerFactory, LoadDatabase);

    public static Dictionary<string, DatabaseMetadata> LoadPathMetadata(string binPath, ILoggerFactory loggerFactory, IEnumerable<string>? databaseNames = null)
        => Load(binPath, loggerFactory, (name, compressed, logger) =>
        {
            using var decompressed = new MemoryStream();
            using (var inflater = new ZLibStream(compressed, CompressionMode.Decompress))
            {
                inflater.CopyTo(decompressed);
            }

            return BinDatabaseReader.ReadPathMetadata(decompressed, name, logger);
        }, databaseNames);

    private static Dictionary<string, T> Load<T>(string binPath, ILoggerFactory loggerFactory, Func<string, Stream, ILogger, T> read,
        IEnumerable<string>? databaseNames = null)
    {
        var logger = loggerFactory.CreateLogger(typeof(DatabaseLoader));
        var result = new Dictionary<string, T>(StringComparer.OrdinalIgnoreCase);
        var selected = databaseNames?.ToHashSet(StringComparer.OrdinalIgnoreCase);

        if (File.Exists(binPath) && Path.GetExtension(binPath).Equals(".pak", StringComparison.OrdinalIgnoreCase))
        {
            logger.LogInformation("Loading packs from compressed pak {BinPath}, will use Bin folder inside ...", binPath);

            using var fs = File.OpenRead(binPath);
            using var zip = new ZipArchive(fs, ZipArchiveMode.Read);

            foreach (var entry in zip.Entries)
            {
                if (Path.GetDirectoryName(entry.FullName) == "Bin" && Path.GetExtension(entry.FullName) == ".bin")
                {
                    var fileName = Path.GetFileName(entry.FullName);
                    if (selected != null && !selected.Contains(fileName))
                    {
                        continue;
                    }

                    using var compressedBin = entry.Open();
                    result.Add(fileName, read(fileName, compressedBin, logger));
                }
            }
        }
        else if (File.Exists(binPath) && Path.GetExtension(binPath).Equals(".bin", StringComparison.OrdinalIgnoreCase))
        {
            using var compressedBin = File.OpenRead(binPath);
            var name = Path.GetFileName(binPath);
            if (selected == null || selected.Contains(name))
            {
                result.Add(name, read(name, compressedBin, logger));
            }
        }
        else if (Directory.Exists(binPath))
        {
            logger.LogInformation("Loading packs from folder {BinPath} ...", binPath);

            foreach (var file in Directory.GetFiles(binPath, "*.bin"))
            {
                var fileName = Path.GetFileName(file);
                if (selected != null && !selected.Contains(fileName))
                {
                    continue;
                }

                using Stream compressedBin = File.OpenRead(file);
                result.Add(fileName, read(fileName, compressedBin, logger));
            }
        }
        else
        {
            throw new ArgumentException("Unsupported Bin argument");
        }

        return result;
    }

    private static BinDatabase LoadDatabase(string name, Stream compressed, ILogger logger)
    {
        using var decompressed = new MemoryStream();
        using (var inflater = new ZLibStream(compressed, CompressionMode.Decompress))
        {
            inflater.CopyTo(decompressed);
        }

        var database = BinDatabaseReader.Read(decompressed, name, logger);

        var versionName = GameVersion.TryGetByVersion(database.Metadata.Version, out var version) ? version.ToString() : "unknown";
        var rootCount = database.Metadata.File2DbId.Count;
        var fileCount = database.Metadata.DbId2ObjId is { } dbId2ObjId ? $"{rootCount + dbId2ObjId.Count} ({rootCount} root)" : $"{rootCount}";
        logger.LogInformation("Loaded database: {File}, version {Version}, {Files} files, {Structs} structs", name, versionName, fileCount,
            database.Metadata.Structs.Count);

        return database;
    }
}

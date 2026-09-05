using System.Collections.Concurrent;
using System.ComponentModel;
using System.Text;
using System.Text.Json;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;
using AllodsOnlineEditorTools.ClientResources.Serialization.Jdb;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using AllodsOnlineEditorTools.ClientResources.Structs;
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Spectre.Console.Cli;

namespace EditorCLI.Commands.Pack;

[UsedImplicitly]
[Description("Unpack bin databases to jdb or xdb files")]
internal sealed class UnpackCommand(ILogger<UnpackCommand> logger, ILoggerFactory loggerFactory) : Command<UnpackCommand.UnpackCommandSettings>
{
    [UsedImplicitly]
    public class UnpackCommandSettings : CommandSettings
    {
        [Description("Path to Bin folder containing databases or path to pak archive containing Bin folder")]
        [CommandArgument(0, "<Bin>")]
        public string BinPath { get; set; } = string.Empty;

        [CommandArgument(1, "[Packs]")]
        [Description("Path to folder containing game data pak files")]
        public string? PacksDirectory { get; set; }

        [CommandOption("-o|--output <out>")]
        [DefaultValue("Unpack")]
        [Description("Output path for unpacked files")]
        public string OutputDirectory { get; set; } = string.Empty;

        [CommandOption("-f|--format <fmt>")]
        [Description("Output format for unpacked files")]
        [DefaultValue(OutputFormat.Xdb)]
        public OutputFormat Format { get; init; }

        [CommandOption("--dry-run")]
        [Description("Enable dry run that does not write files to disk")]
        public bool Dry { get; set; }

        [CommandOption("--strict")]
        [Description("Fail if any struct referenced by the databases has no implementation")]
        public bool Strict { get; set; }

        [CommandOption("--localization <PATH>")]
        [Description("17.x pack.<locale>.loc; its sibling .bin supplies localized resource references")]
        public string? Localization { get; init; }

        [CommandOption("--paths-from <Bin>")]
        [Description("Restore stripped resource paths from an older Bin directory, pack.bin, or pak containing Bin, such as 14.0.01.77")]
        public string? PathsFrom { get; init; }

        [CommandOption("--type <NAME>")]
        [Description("Export only the named resource type")]
        public string? Type { get; init; }

        [CommandOption("--as <version>")]
        [Description(
            "Cast resources to another game version (see supported versions) before serializing, incompatible resources/fields are skipped with a warning")]
        public string? CastToVersion { get; set; }
    }

    protected override int Execute(CommandContext context, UnpackCommandSettings settings, CancellationToken cancellationToken)
    {
        var databases = DatabaseLoader.LoadDatabases(settings.BinPath, loggerFactory);

        if (!databases.TryGetValue("pack.bin", out var mainDatabase))
        {
            throw new InvalidDataException($"No pack.bin database found in '{settings.BinPath}'; cannot unpack without the main database");
        }

        BinDatabase? localizedDatabase = null;
        LocalizationTable? localization = null;
        if (settings.Localization is not null)
        {
            localization = LocalizationTable.Load(settings.Localization);
            var sibling = Path.ChangeExtension(settings.Localization, ".bin");
            if (!File.Exists(sibling))
            {
                throw new FileNotFoundException("Localization resource database is missing", sibling);
            }

            var loaded = DatabaseLoader.LoadDatabases(sibling, loggerFactory);
            localizedDatabase = loaded.Single().Value;
            // Load only the selected locale, even when the input folder contains others.
            foreach (var name in databases.Keys.Where(n => n.StartsWith("pack.") && n != "pack.bin").ToArray())
            {
                databases.Remove(name);
            }

            databases[Path.GetFileName(sibling)] = localizedDatabase.Value;
        }
        var mainMetadata = mainDatabase.Metadata;
        foreach (var (name, db) in databases)
        {
            if (!db.Metadata.Version.SequenceEqual(mainMetadata.Version))
            {
                throw new InvalidDataException($"Database {name} has a different version header than pack.bin");
            }
        }

        if (!GameVersion.TryGetByVersion(mainMetadata.Version, out var version))
        {
            throw new NotSupportedException($"Unsupported version: 0x{Convert.ToHexString(mainMetadata.Version)}");
        }

        if (!version.HasStructs)
        {
            throw new NotSupportedException($"Unsupported version: {version} has no struct definitions, nothing can be unpacked");
        }

        PacksRegistry? packsRegistry = null;
        if (version.NeedPacks)
        {
            if (settings.PacksDirectory is null)
            {
                throw new ArgumentException($"Version {version} requires a Packs directory; pass it as the second argument, " +
                                            $"e.g. 'unpack {settings.BinPath} <path-to-folder-containing-game-data-pak-files>'");
            }

            logger.LogInformation("Loading packs from {PacksDirectory}", settings.PacksDirectory);
            packsRegistry = PacksRegistry.Load(settings.PacksDirectory);
        }

        logger.LogInformation("Loading structs for version {version}", version.ToString());
        var typeResolver = InitStructs(databases, version, settings.Strict);

        var pathRecovery = new List<PathRecoveryReport>();
        if (settings.PathsFrom is not null)
        {
            var references = DatabaseLoader.LoadPathMetadata(settings.PathsFrom, loggerFactory, databases.Keys);
            if (references.Count == 0)
            {
                throw new InvalidDataException("The path reference contains no databases matching the export input");
            }

            var catalog = new ResourcePathCatalog(references);
            foreach (var report in catalog.RestoreMissingPaths(databases, packsRegistry, typeResolver))
            {
                pathRecovery.Add(report);
                logger.LogInformation("Paths for {Database}: {Restored} restored ({PayloadMatches} payload matches); {Unmatched} unmatched; {Ambiguous} ambiguous IDs; {Mismatched} type mismatches; {Conflicts} path conflicts; {Invalid} invalid paths",
                    report.Database, report.Restored, report.PayloadMatches, report.Unmatched, report.AmbiguousIds, report.TypeMismatches, report.PathConflicts, report.InvalidPaths);
            }
        }
        foreach (var (name, db) in databases)
        {
            DatabaseExport.AssignMissingPaths(db, name);
        }

        if (settings.Type is not null && !typeResolver.TryResolveByName(settings.Type, out _))
        {
            throw new ArgumentException($"Unknown resource type '{settings.Type}' for {version}");
        }

        var localizedOffsets = localizedDatabase is { } localized ? DatabaseExport.ReadLocalizedResources(localized, typeResolver) : null;
        var textFiles = new ConcurrentDictionary<string, string>();
        var failures = new ConcurrentDictionary<string, string>();
        var exported = 0;
        var unnamed = 0;
        var semanticTextFiles = 0;
        var caster = settings.CastToVersion is null ? null : CreateCaster(settings.CastToVersion, version, databases, settings.Strict);

        if (!settings.Dry)
        {
            Directory.CreateDirectory(settings.OutputDirectory);
        }

        int totalFiles = databases.Values.Sum(d => d.Metadata.DbId2File.Count);

        logger.LogInformation("Start unpacking {TotalFiles} files", totalFiles);

        var extension = settings.Format.ToString().ToLowerInvariant();
        var binaryOptions = BinarySerializerOptions.Default;

        var processedFiles = 0;
        var lastLoggedDecile = 0;
        var progressLock = new Lock();

        void ReportProgress()
        {
            var done = Interlocked.Increment(ref processedFiles);
            var decile = (int)(done * 10L / totalFiles);
            if (decile <= lastLoggedDecile)
            {
                return;
            }

            lock (progressLock)
            {
                if (decile <= lastLoggedDecile)
                {
                    return;
                }

                lastLoggedDecile = decile;
                logger.LogInformation("Unpacked {Processed}/{Total} files ({Percent}%)", done, totalFiles, decile * 10);
            }
        }

        foreach (var entry in databases)
        {
            var databaseMetadata = entry.Value.Metadata;
            var databaseData = entry.Value.Data;
            var serializerContext = new BinaryStructSerializerContext()
            {
                CurrentDatabaseMetadata = databaseMetadata,
                MainDatabaseMetadata = mainMetadata,
                TypeResolver = typeResolver,
                FileRefKind = version.FileRefKind,
                Packs = packsRegistry,
                LoggerFactory = loggerFactory,
                MainDatabase = mainDatabase,
                LocalizedDatabase = localizedDatabase,
                LocalizedResourceOffsets = localizedOffsets,
                Localization = localization,
                LocalizationDirectory = "__localized/" + Path.GetFileNameWithoutExtension(settings.Localization ?? "pack"),
                TextFileRead = (name, text) => textFiles.TryAdd(name, text),
            };

            Parallel.ForEach(databaseMetadata.DbId2File, fileEntry =>
            {
                if (settings.Type is not null && databaseMetadata.GetStructType(fileEntry.Key) != settings.Type)
                {
                    ReportProgress();
                    return;
                }
                try
                {
                    var sidecars = settings.Format == OutputFormat.Xdb && localization is not null
                        ? new XdbResourceTextFiles(fileEntry.Value, name => textFiles.GetValueOrDefault(name)) : null;
                    var resourceContext = new ResourceSerializationContext
                    {
                        EnumRefOverrides = caster?.EnumRefOverrides,
                        TextFileHref = sidecars is null ? null : sidecars.GetHref,
                    };
                    var serializer = CreateSerializer(settings.Format, resourceContext, loggerFactory);
                    if (caster is not null)
                    {
                        var structName = databaseMetadata.GetStructType(fileEntry.Key);
                        if (structName is null || !caster.CanCast(structName))
                        {
                            ReportProgress();
                            return;
                        }
                    }

                    using (logger.BeginScope("Database:{Database} File:{File}", entry.Key, fileEntry.Value))
                    {
                        var result = BinaryStructSerializer.Deserialize(databaseData, fileEntry.Key, serializerContext, binaryOptions);
                        if (caster is not null)
                        {
                            result = caster.Cast(result, resourceContext);
                        }

                        databaseMetadata.DbId2ResId.TryGetValue(fileEntry.Key, out int resourceId);
                        var content = serializer.SerializeResource(result, resourceId);

                        if (!settings.Dry)
                        {
                            var path = OutputPath(settings.OutputDirectory, Path.ChangeExtension(fileEntry.Value, extension));
                            Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                            File.WriteAllText(path, content);
                            if (sidecars is not null)
                            {
                                foreach (var (name, text) in sidecars.Files)
                                {
                                    File.WriteAllText(OutputPath(settings.OutputDirectory, name), text, Encoding.Unicode);
                                }
                            }
                        }
                    }

                    Interlocked.Increment(ref exported);
                    Interlocked.Add(ref semanticTextFiles, sidecars?.Files.Count ?? 0);
                    if (DatabaseExport.IsUnnamedPath(fileEntry.Value))
                    {
                        Interlocked.Increment(ref unnamed);
                    }
                }
                catch (Exception error) when (error is InvalidDataException or InvalidOperationException or ArgumentException or KeyNotFoundException or OverflowException or NotSupportedException)
                {
                    failures[$"{entry.Key}:{fileEntry.Value}"] = error.Message;
                }
                ReportProgress();
            });
        }

        if (!settings.Dry)
        {
            foreach (var (name, text) in settings.Format == OutputFormat.Xdb ? [] : textFiles)
            {
                var path = OutputPath(settings.OutputDirectory, name);
                Directory.CreateDirectory(Path.GetDirectoryName(path)!);
                File.WriteAllText(path, text, Encoding.Unicode);
            }
            File.WriteAllText(OutputPath(settings.OutputDirectory, "unpack-report.json"),
                JsonSerializer.Serialize(new
                {
                    exported,
                    named = exported - unnamed,
                    unnamed,
                    localizedTextFiles = settings.Format == OutputFormat.Xdb ? semanticTextFiles : textFiles.Count,
                    failed = failures.Count,
                    failures,
                    pathRecovery,
                    outputDirectory = Path.GetFullPath(settings.OutputDirectory),
                    unnamedOutputDirectory = Path.GetFullPath(Path.Combine(settings.OutputDirectory, "_unnamed")),
                }, new JsonSerializerOptions { WriteIndented = true }));
        }
        logger.LogInformation("Decoded {Count} resources; {Failed} failed; {Texts} localized text files", exported, failures.Count,
            settings.Format == OutputFormat.Xdb ? semanticTextFiles : textFiles.Count);
        logger.LogInformation("Resource paths: {Named} named; {Unnamed} unnamed", exported - unnamed, unnamed);
        foreach (var failure in failures.Take(20))
        {
            logger.LogWarning("{Resource}: {Reason}", failure.Key, failure.Value);
        }

        return failures.IsEmpty ? 0 : 1;
    }

    private static string OutputPath(string root, string relative)
    {
        var fullRoot = Path.GetFullPath(root).TrimEnd(Path.DirectorySeparatorChar) + Path.DirectorySeparatorChar;
        var path = Path.GetFullPath(Path.Combine(fullRoot, relative.Replace('/', Path.DirectorySeparatorChar)));
        if (!path.StartsWith(fullRoot, OperatingSystem.IsWindows() ? StringComparison.OrdinalIgnoreCase : StringComparison.Ordinal))
        {
            throw new InvalidDataException($"Resource path escapes the output directory: {relative}");
        }

        return path;
    }

    private static IResourceWriter CreateSerializer(OutputFormat format, ResourceSerializationContext context, ILoggerFactory loggerFactory) => format switch
    {
        OutputFormat.Jdb => new JdbStructSerializer(JdbStructSerializerOptions.Default, context, loggerFactory.CreateLogger<JdbStructSerializer>()),
        OutputFormat.Xdb => new XdbStructSerializer(XdbStructSerializerOptions.Default, context, loggerFactory.CreateLogger<XdbStructSerializer>()),
        _ => throw new NotSupportedException($"Unsupported output format: {format}"),
    };

    private StructCaster CreateCaster(string targetNamespace, GameVersion sourceVersion, Dictionary<string, BinDatabase> databases, bool strictMode)
    {
        if (!GameVersion.TryGetByNamespace(targetNamespace, out var targetVersion))
        {
            throw new ArgumentException($"Unknown cast target version '{targetNamespace}'; known versions: {string.Join(", ", GameVersion.StructNamespaces)}");
        }

        var targetStructs = StructTypeResolver.FromVersion(targetVersion).ByName;
        if (targetStructs.Count == 0)
        {
            throw new InvalidOperationException($"Cast target version '{targetNamespace}' has no compiled structs");
        }

        logger.LogInformation("Casting resources from {Source} to {Target}", sourceVersion, targetVersion);

        var caster = new StructCaster(StructTypeResolver.FromVersion(sourceVersion).ByName, targetStructs, loggerFactory.CreateLogger<StructCaster>());
        caster.Analyze(databases.Values.SelectMany(d => d.Metadata.Structs).Distinct());

        if (caster.IncompatibilityCount > 0)
        {
            if (strictMode)
            {
                throw new InvalidOperationException($"{caster.IncompatibilityCount} struct(s)/field(s) cannot be cast to '{targetNamespace}' (strict mode)");
            }

            logger.LogWarning("{Count} struct(s)/field(s) cannot be cast to {Target} and will be skipped", caster.IncompatibilityCount, targetNamespace);
        }

        return caster;
    }

    private StructTypeResolver InitStructs(Dictionary<string, BinDatabase> databases, GameVersion allodsGameVersion, bool strictMode)
    {
        var typeResolver = StructTypeResolver.FromVersion(allodsGameVersion, loggerFactory.CreateLogger<StructTypeResolver>());

        var structs = databases.Values.SelectMany(d => d.Metadata.Structs).ToHashSet();
        var missingStructs = structs.Except(typeResolver.Types.Select(s => s.Name)).ToList();

        foreach (var missingStruct in missingStructs)
        {
            logger.LogWarning("Missing struct definition, will not unpack: {MissingStruct}", missingStruct);
        }

        if (missingStructs.Count > 0 && strictMode)
        {
            throw new InvalidOperationException($"{missingStructs.Count} struct(s) referenced by the databases have no implementation (strict mode)");
        }

        return typeResolver;
    }
}

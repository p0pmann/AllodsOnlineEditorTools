using System.ComponentModel;
#if !IS_OPEN_SOURCE_BUILD
using AllodsOnlineEditorTools.StructCodeGeneration;
#endif
using JetBrains.Annotations;
using Microsoft.Extensions.Logging;
using Spectre.Console;
using Spectre.Console.Cli;

namespace EditorCLI.Commands.Generation;

[UsedImplicitly]
[Description("Recover x64 struct layouts from client serializers and validate them against pack.bin")]
internal sealed class GenerateStructCodeCommand(ILogger<GenerateStructCodeCommand> logger)
    : Command<GenerateStructCodeCommand.GenerateStructCodeCommandSettings>
{
    [UsedImplicitly]
    public class GenerateStructCodeCommandSettings : CommandSettings
    {
        [CommandArgument(0, "<Bin>")]
        [Description("pack.bin or its Bin directory")]
        public string BinPath { get; init; } = string.Empty;

        [CommandArgument(1, "<version>")]
        [Description("Generated namespace, e.g. V17_0_01_49")]
        public string Version { get; init; } = string.Empty;

        [CommandOption("--image <PATH>")]
        [Description("Decrypted PE image; use --pid instead for read-only live capture")]
        public string? Image { get; init; }

        [CommandOption("--pid <PID>")]
        public int? ProcessId { get; init; }

        [CommandOption("--profile <PATH>")]
        [Description("Version-specific helper addresses and database identity; defaults to 17.0.01.49")]
        public string? Profile { get; init; }

        [CommandOption("--output-dir <PATH>")]
        [DefaultValue("output")]
        public string OutputDirectory { get; init; } = "output";

        [CommandOption("--localization <PATH>")]
        [Description("Matching pack.<locale>.loc, used to validate text-reference indices")]
        public string? Localization { get; init; }

        [CommandOption("--allow-partial")]
        [Description("Emit verified layouts and report excluded layouts")]
        public bool AllowPartial { get; init; }

        [CommandOption("--dry-run")]
        public bool DryRun { get; init; }

#if !IS_OPEN_SOURCE_BUILD
        public override ValidationResult Validate() => (Image is null) == (ProcessId is null) || ProcessId is <= 0
            ? ValidationResult.Error("Provide exactly one of --image or a positive --pid.")
            : ValidationResult.Success();
#endif
    }

    protected override int Execute(CommandContext context, GenerateStructCodeCommandSettings settings, CancellationToken cancellationToken)
    {
#if IS_OPEN_SOURCE_BUILD
        logger.LogError("Struct code generation is not included in the open-source build of AllodsOnlineEditorTools.");
        return 1;
#else
        try
        {
            StructRecovery.Generate(new GenerationOptions
            {
                BinPath = settings.BinPath,
                VersionNamespace = settings.Version,
                ProfilePath = settings.Profile ?? Path.Combine(AppContext.BaseDirectory, "StructCodeGeneration", "profiles", "17.0.01.49.json"),
                ImagePath = settings.Image,
                ProcessId = settings.ProcessId,
                OutputDirectory = settings.OutputDirectory,
                LocalizationPath = settings.Localization,
                AllowPartial = settings.AllowPartial,
                DryRun = settings.DryRun,
            }, Console.WriteLine, cancellationToken);
            return 0;
        }
        catch (Exception error) when (error is IOException or ArgumentException or Win32Exception or InvalidOperationException or PlatformNotSupportedException)
        {
            logger.LogError(error, "Struct generation failed: {Message}", error.Message);
            return 1;
        }
#endif
    }
}

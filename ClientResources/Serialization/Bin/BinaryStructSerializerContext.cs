using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;
using Microsoft.Extensions.Logging;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin;

public class BinaryStructSerializerContext
{
    public int PointerSize => CurrentDatabaseMetadata.PointerSize;
    public required DatabaseMetadata CurrentDatabaseMetadata { get; set; }
    public required DatabaseMetadata MainDatabaseMetadata { get; set; }
    public required StructTypeResolver TypeResolver { get; set; }
    public FileRefKind FileRefKind { get; set; } = FileRefKind.None;
    public PacksRegistry? Packs { get; set; }
    public LocalizationTable? Localization { get; set; }
    public string LocalizationDirectory { get; set; } = "__localized";
    public Action<string, string>? TextFileRead { get; set; }
    public BinDatabase? MainDatabase { get; set; }
    public BinDatabase? LocalizedDatabase { get; set; }
    public IReadOnlyList<long?>? LocalizedResourceOffsets { get; set; }

    public BinaryStructSerializerContext ForDatabase(BinDatabase database)
    {
        var copy = (BinaryStructSerializerContext)MemberwiseClone();
        copy.CurrentDatabaseMetadata = database.Metadata;
        return copy;
    }

    public ILoggerFactory? LoggerFactory { get; set; }

    public string ResolvePakFileRef(int packIndex, int fileIndex)
    {
        if (packIndex == 0 && fileIndex == -1 || packIndex == -1 && fileIndex == 0)
        {
            return "";
        }

        if (Packs is null || CurrentDatabaseMetadata.Packs is null)
        {
            throw new InvalidOperationException("Cannot resolve PakFileRef without a packs registry and database pack list");
        }

        return Packs.GetFilename(CurrentDatabaseMetadata.Packs[packIndex], fileIndex);
    }
}

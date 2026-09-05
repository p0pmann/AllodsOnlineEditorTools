using System.Diagnostics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;

internal class TextFileRefBinaryConverter : BinaryConverter<TextFileRef>
{
    public override int GetSize(Type type, BinaryStructSerializerContext context) => 4 * context.PointerSize;

    protected override TextFileRef ReadValue(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context)
    {
        var txtFile = context.PointerSize == 8 ? string.Empty : reader.ReadString(offset);
        FieldValidator.ValidateTextFileRef(txtFile, offset);
        var id = reader.ReadWord(offset + 3 * context.PointerSize);
        if (context.PointerSize == 8 && id >= 0)
        {
            var text = context.Localization?.GetText(id) ??
                       throw new InvalidDataException($"TextFileRef at {offset} needs localization entry {id}; supply --localization");
            var name = $"{context.LocalizationDirectory}/{id}.txt";
            context.TextFileRead?.Invoke(name, text);
            return new TextFileRef(name);
        }
        // I have only seen id = -1 in V7+ up to now
        Debug.Assert(id == -1 || (context.MainDatabaseMetadata.TextFileRefNames is { } names && names.TryGetValue(checked((int)id), out var tableName) && tableName == txtFile),
            $"TextFileRef at offset {offset} has txt-files table id {id} which does not map back to '{txtFile}'");
        return new TextFileRef(txtFile);
    }

    protected override void WriteValue(BinaryStructWriter writer, long offset, TextFileRef value, BinaryStructSerializerContext context)
    {
        throw new NotImplementedException();
    }
}

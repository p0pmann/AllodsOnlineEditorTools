using System.Diagnostics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;

internal class ResourcePointerBinaryConverter : BinaryConverter<ResourcePointer>
{
    public override int GetSize(Type type, BinaryStructSerializerContext context) => 8;

    protected override ResourcePointer ReadValue(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context)
    {
        if (!reader.TryGetPointerFix(offset, out var pointerFix))
        {
            if (context.PointerSize == 8 && reader.ReadWord(offset) != 0)
            {
                throw new InvalidDataException($"Non-null pointer at {offset} has no relocation");
            }

            return ResourcePointer.Empty;
        }

        Debug.Assert(reader.ReadInt(offset) == 0);
        //BUG: Debug.Assert(reader.ReadInt(offset + 4) == 0);
        if (pointerFix.Type == PointerFix.FixType.Unresolved)
        {
            if (context.LocalizedDatabase is not { } localized || context.LocalizedResourceOffsets is not { } offsets ||
                pointerFix.Value < 0 || pointerFix.Value >= offsets.Count || offsets[(int)pointerFix.Value] is not { } target)
            {
                throw new InvalidDataException($"Unresolved localized resource {pointerFix.Value} at {offset}");
            }

            return Resolve(localized.Metadata, target, context);
        }
        if (pointerFix.Type != PointerFix.FixType.DbIdRef)
        {
            throw new InvalidDataException($"Invalid resource relocation at {offset}: {pointerFix.Type}");
        }

        var database = pointerFix.External ? context.MainDatabaseMetadata : context.CurrentDatabaseMetadata;
        return Resolve(database, pointerFix.Value, context);
    }

    private static ResourcePointer Resolve(DatabaseMetadata database, long target, BinaryStructSerializerContext context)
    {
        var file = database.DbId2File[target];

        var structName = database.GetStructType(target) ?? throw new InvalidOperationException($"No struct type for DbId {target}.");
        var type = context.TypeResolver.TryResolveByName(structName, out var impl) ? impl : null;
        return new ResourcePointer(file, type);
    }

    protected override void WriteValue(BinaryStructWriter writer, long offset, ResourcePointer value, BinaryStructSerializerContext context)
    {
        throw new NotImplementedException();
    }
}

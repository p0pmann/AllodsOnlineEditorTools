using System.Diagnostics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;

internal class NullablePointerBinaryConverter : BinaryConverter<NullablePointer>
{
    public override int GetSize(Type type, BinaryStructSerializerContext context) => context.PointerSize;

    protected override NullablePointer ReadValue(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context)
    {
        if (!reader.TryGetPointerFix(offset, out var pointerFix))
        {
            if (context.PointerSize == 8 && reader.ReadWord(offset) != 0)
            {
                throw new InvalidDataException($"Non-null pointer at {offset} has no relocation");
            }

            return NullablePointer.Empty;
        }

        if (pointerFix.Type is not (PointerFix.FixType.DbIdRef or PointerFix.FixType.Unresolved))
        {
            throw new InvalidDataException($"Invalid polymorphic relocation at {offset}: {pointerFix.Type}");
        }

        if (pointerFix.External || pointerFix.Type == PointerFix.FixType.Unresolved)
        {
            var database = pointerFix.External ? context.MainDatabase : context.LocalizedDatabase;
            var target = pointerFix.Value;
            if (pointerFix.Type == PointerFix.FixType.Unresolved)
            {
                if (context.LocalizedResourceOffsets is not { } offsets || target < 0 || target >= offsets.Count || offsets[(int)target] is not { } resolved)
                {
                    throw new InvalidDataException($"Unresolved localized pointer at {offset}");
                }

                target = resolved;
            }
            if (database is not { } db)
            {
                throw new InvalidDataException($"Polymorphic pointer at {offset} requires another database");
            }

            var other = new BinaryStructReader(db.Data, context.ForDatabase(db), BinarySerializerOptions.Default);
            return new NullablePointer(other.ReadObject(target, other.ReadType(target, true)));
        }
        var type = reader.ReadType(pointerFix.Value, true);
        var nested = reader.ReadObject(pointerFix.Value, type);
        Debug.Assert(nested != null);
        return new NullablePointer(nested);
    }

    protected override void WriteValue(BinaryStructWriter writer, long offset, NullablePointer value, BinaryStructSerializerContext context)
    {
        throw new NotImplementedException();
    }
}

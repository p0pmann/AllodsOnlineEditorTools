using System.Diagnostics;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;

internal class ArrayBinaryConverter : BinaryConverter<Array>
{
    public override int GetSize(Type type, BinaryStructSerializerContext context) => 4 * context.PointerSize;

    public override bool CanConvert(Type type)
    {
        return type.IsArray;
    }

    protected override Array ReadValue(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context)
        => ReadArray(ref reader, offset, typeToConvert, context, 0);

    internal static Array ReadArray(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context, int stride)
    {
        var elementType = typeToConvert.GetElementType();
        Debug.Assert(elementType is not null);
        var arrayMemorySize = reader.ReadWord(offset + context.PointerSize);
        if (!reader.TryGetPointerFix(offset, out var pointerFix))
        {
            if (arrayMemorySize != 0)
            {
                throw new InvalidDataException($"Nonempty vector at {offset} has no relocation");
            }

            return Array.CreateInstance(elementType, 0);
        }

        if (pointerFix.Type != PointerFix.FixType.Direct && !(context.PointerSize == 8 && pointerFix.Type == PointerFix.FixType.DbIdRef && !pointerFix.External))
        {
            throw new InvalidDataException($"Invalid vector relocation at {offset}: {pointerFix.Type}");
        }

        var elementSize = stride > 0 ? stride : reader.GetSize(elementType);
        if (elementSize <= 0 || arrayMemorySize < 0 || arrayMemorySize % elementSize != 0)
        {
            throw new InvalidDataException($"Invalid vector byte length {arrayMemorySize} for element size {elementSize} at {offset}");
        }
        reader.ValidateRange(pointerFix.Value, arrayMemorySize);
        var elementCount = checked((int)(arrayMemorySize / elementSize));
        var result = Array.CreateInstance(elementType, elementCount);

        for (var i = 0; i < elementCount; i++)
        {
            var element = reader.ReadField(pointerFix.Value + i * elementSize, elementType);
            result.SetValue(element, i);
        }

        return result;
    }

    protected override void WriteValue(BinaryStructWriter writer, long offset, Array? value, BinaryStructSerializerContext context)
    {
        throw new NotImplementedException();
    }
}

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;

internal class PrimitivesBinaryConverter : BinaryConverter<object>
{
    public override int GetSize(Type type, BinaryStructSerializerContext context)
    {
        if (type == typeof(bool) || type == typeof(byte) || type == typeof(sbyte))
        {
            return 1;
        }

        if (type == typeof(short) || type == typeof(ushort))
        {
            return 2;
        }

        if (type == typeof(int) || type == typeof(uint) || type == typeof(float))
        {
            return 4;
        }

        if (type == typeof(long) || type == typeof(ulong) || type == typeof(double))
        {
            return 8;
        }

        if (type == typeof(string))
        {
            return 3 * context.PointerSize;
        }

        throw new NotSupportedException($"Unknown primitive: {type.Name}");
    }

    public override bool CanConvert(Type type)
    {
        return type.IsPrimitive || type == typeof(string);
    }

    protected override object ReadValue(ref BinaryStructReader reader, long offset, Type typeToConvert, BinaryStructSerializerContext context)
    {
        if (typeToConvert == typeof(byte))
        {
            return reader.ReadByte(offset);
        }

        if (typeToConvert == typeof(sbyte))
        {
            return unchecked((sbyte)reader.ReadByte(offset));
        }

        if (typeToConvert == typeof(short))
        {
            return reader.ReadShort(offset);
        }

        if (typeToConvert == typeof(ushort))
        {
            return unchecked((ushort)reader.ReadShort(offset));
        }

        if (typeToConvert == typeof(uint))
        {
            return unchecked((uint)reader.ReadInt(offset));
        }

        if (typeToConvert == typeof(ulong))
        {
            return unchecked((ulong)reader.ReadLong(offset));
        }

        if (typeToConvert == typeof(int))
        {
            return reader.ReadInt(offset);
        }

        if (typeToConvert == typeof(long))
        {
            return reader.ReadLong(offset);
        }

        if (typeToConvert == typeof(float))
        {
            return reader.ReadFloat(offset);
        }

        if (typeToConvert == typeof(double))
        {
            return reader.ReadDouble(offset);
        }

        if (typeToConvert == typeof(bool))
        {
            return reader.ReadBool(offset);
        }

        if (typeToConvert == typeof(string))
        {
            var value = reader.ReadString(offset);
            FieldValidator.ValidatePlainString(value, offset);
            return value;
        }

        throw new NotSupportedException($"Unknown primitive: {typeToConvert.Name}");
    }

    protected override void WriteValue(BinaryStructWriter writer, long offset, object? value, BinaryStructSerializerContext context)
    {
        throw new NotImplementedException();
    }
}

using System.Buffers.Binary;
using System.Diagnostics;
using System.Text;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Converters;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin;

public ref struct BinaryStructReader(ReadOnlySpan<byte> buffer, BinaryStructSerializerContext context, BinarySerializerOptions options)
{
    private readonly ReadOnlySpan<byte> _buffer = buffer;
    private long _ownerOffset = -1;

    public Type ReadType(long offset, bool nullable)
    {
        if (!context.CurrentDatabaseMetadata.Fixes.TryGetValue(offset, out var fix))
        {
            throw new InvalidDataException($"No pointer fix found at offset {offset}");
        }

        if (fix.Type is not (PointerFix.FixType.Type or PointerFix.FixType.Generic))
        {
            throw new InvalidDataException($"Expected a type pointer fix at offset {offset}, got {fix.Type}");
        }

        var structName = context.CurrentDatabaseMetadata.Structs[checked((int)fix.Value)];
        if (!context.TypeResolver.TryResolveByName(structName, out var type))
        {
            throw new InvalidOperationException($"Struct implementation not found for '{structName}'");
        }

        //BUG: Debug.Assert(ReadInt(offset + 16) == 1 || nullable || type.Name == "Territory");
        //BUG: TerritoriesRegistry + NameRules + Textures in V14 (all localized ?)
        Debug.Assert(context.PointerSize == 8 || ReadInt(offset + 4) == 1 || ReadInt(offset + 4) == 2 && type.Name == "Territory");
        return type;
    }

    public object ReadObject(long offset, Type type)
    {
        if (type.IsAbstract)
        {
            throw new InvalidOperationException($"Cannot read abstract type '{type.Name}'");
        }

        if (_ownerOffset < 0)
        {
            _ownerOffset = offset;
        }

        var result = Activator.CreateInstance(type) ?? throw new InvalidOperationException($"Failed to create instance of '{type.Name}'");
        foreach (var field in StructModelCache.Get(type).Fields)
        {
            if (field.Offset is not { } fieldOffset)
            {
                throw new InvalidOperationException($"Field '{type.Name}.{field.Name}' is missing {nameof(FieldOffsetAttribute)}");
            }

            var value = field.EmbeddedVirtual && context.PointerSize == 8
                ? ReadEmbeddedVirtual(offset + fieldOffset, field.FieldType)
                : field.ArrayStride > 0
                ? ArrayBinaryConverter.ReadArray(ref this, offset + fieldOffset, field.FieldType, context, field.ArrayStride)
                : ReadField(offset + fieldOffset, field.FieldType);
            if (field.EnumRef is not null)
            {
                FieldValidator.ValidateEnumRef(field.Field, offset + fieldOffset, field.EnumRef, value);
            }

            field.SetValue(result, value);
        }

        return result;
    }

    private object ReadEmbeddedVirtual(long offset, Type type)
    {
        var metadata = context.CurrentDatabaseMetadata;
        if (metadata.Fixes.ContainsKey(offset))
        {
            return ReadObject(offset, ReadType(offset, true));
        }

        if (!NeedsRelocatedCopy(offset, type))
        {
            return ReadObject(offset, type);
        }

        var end = metadata.NextRootOffset(_ownerOffset, _buffer.Length);
        long? match = null;
        for (var candidate = offset + 8; candidate < end; candidate += 8)
        {
            if (!metadata.Fixes.TryGetValue(candidate, out var fix) || fix.Type != PointerFix.FixType.Generic ||
                metadata.GetStructType(candidate) != type.Name || !ScalarFieldsMatch(offset, candidate, type))
            {
                continue;
            }

            if (match is not null)
            {
                throw new InvalidDataException($"Multiple relocated copies of {type.Name} match embedded object {offset}");
            }

            match = candidate;
        }
        // An empty embedded value may have no orphan. Its normal field readers still reject any
        // nonempty unrelocated payload rather than replacing it with empty data.
        return ReadObject(match ?? offset, type);
    }

    private bool NeedsRelocatedCopy(long offset, Type type)
    {
        foreach (var field in StructModelCache.Get(type).Fields)
        {
            var at = offset + (field.Offset ?? throw new InvalidDataException($"No offset for {field.Name}"));
            if (field.FieldType == typeof(string) || field.FieldType == typeof(AllodsOnlineEditorTools.ClientResources.DataTypes.WString) || field.FieldType.IsArray)
            {
                if (!TryGetPointerFix(at, out _) && ReadWord(at + 8) != 0)
                {
                    return true;
                }
            }
            else if (field.FieldType == typeof(AllodsOnlineEditorTools.ClientResources.DataTypes.ResourcePointer) ||
                     field.FieldType == typeof(AllodsOnlineEditorTools.ClientResources.DataTypes.NullablePointer))
            {
                if (!TryGetPointerFix(at, out _) && ReadWord(at) != 0)
                {
                    return true;
                }
            }
            else if (field.FieldType.IsClass && NeedsRelocatedCopy(at, field.FieldType))
            {
                return true;
            }
        }
        return false;
    }

    private bool ScalarFieldsMatch(long embedded, long candidate, Type type)
    {
        foreach (var field in StructModelCache.Get(type).Fields)
        {
            if (field.Offset is not { } offset)
            {
                throw new InvalidDataException($"No offset for {field.Name}");
            }

            var fieldType = field.FieldType;
            if (fieldType.IsPrimitive)
            {
                var size = GetSize(fieldType);
                ValidateRange(candidate + offset, size);
                if (!_buffer.Slice(checked((int)(embedded + offset)), size).SequenceEqual(_buffer.Slice(checked((int)(candidate + offset)), size)))
                {
                    return false;
                }
            }
            else if (fieldType == typeof(string) || fieldType == typeof(AllodsOnlineEditorTools.ClientResources.DataTypes.WString) || fieldType.IsArray)
            {
                // The embedded native container holds absolute pointers; the saved copy holds lengths.
                continue;
            }
            else if (fieldType.IsClass && !ScalarFieldsMatch(embedded + offset, candidate + offset, fieldType))
            {
                return false;
            }
        }
        return true;
    }

    public object? ReadField(long offset, Type type)
    {
        var converter = options.GetConverter(type);
        if (converter is not null)
        {
            return converter.Read(ref this, offset, type, context);
        }

        return type.IsClass ? ReadObject(offset, type) : throw new InvalidOperationException($"No binary converter registered for type '{type.Name}'");
    }

    public void ValidateRange(long offset, long length)
    {
        if (offset < 0 || length < 0 || offset > _buffer.Length || length > _buffer.Length - offset)
        {
            throw new InvalidDataException($"Range {offset}+{length} exceeds the database data chunk");
        }
    }

    public byte ReadByte(long offset) => _buffer[checked((int)offset)];
    public short ReadShort(long offset) => BinaryPrimitives.ReadInt16LittleEndian(_buffer.Slice(checked((int)offset), 2));

    public int ReadInt(long offset) => BinaryPrimitives.ReadInt32LittleEndian(_buffer.Slice(checked((int)offset), 4));

    public long ReadLong(long offset) => BinaryPrimitives.ReadInt64LittleEndian(_buffer.Slice(checked((int)offset), 8));

    public long ReadWord(long offset) => context.PointerSize == 8 ? ReadLong(offset) : ReadInt(offset);

    public float ReadFloat(long offset) => BinaryPrimitives.ReadSingleLittleEndian(_buffer.Slice(checked((int)offset), 4));

    public double ReadDouble(long offset) => BinaryPrimitives.ReadDoubleLittleEndian(_buffer.Slice(checked((int)offset), 8));

    public bool ReadBool(long offset) => _buffer[checked((int)offset)] != 0;

    // Default string payloads (plain strings, file refs, text-file refs) are single-byte/ASCII;
    // only fields the schema marks as wide (WString) are UTF-16LE. The length prefix is a byte count either way.
    public string ReadString(long offset)
    {
        var result = ReadString(offset, Encoding.UTF8);
        Debug.Assert(!HasInvalidControlCharacters(result),
            $"String at offset {offset} contains invalid control characters (likely a WString/String encoding mismatch): '{result}'");
        return result;
    }

    public string ReadUnicodeString(long offset) => ReadString(offset, Encoding.Unicode);

    // Control characters other than tab/newline/carriage-return: their presence in a decoded string
    // usually signals a String/WString encoding mismatch (single-byte data read as UTF-16LE or vice versa).
    public static bool HasInvalidControlCharacters(string value) =>
        value.Any(c => c < 0x20 && c != '\t' && c != '\n' && c != '\r');

    private string ReadString(long offset, Encoding encoding)
    {
        if (!context.CurrentDatabaseMetadata.Fixes.TryGetValue(offset, out var fix))
        {
            if (context.PointerSize == 8 && ReadWord(offset + context.PointerSize) != 0)
            {
                throw new InvalidDataException($"Nonempty string at {offset} has no relocation");
            }

            return string.Empty;
        }

        if (fix.Type != PointerFix.FixType.Direct)
        {
            throw new InvalidDataException($"Expected a direct pointer fix for string at offset {offset}, got {fix.Type}");
        }

        var length = checked((int)ReadWord(offset + context.PointerSize));
        if (length < 0)
        {
            throw new InvalidDataException($"Negative string length ({length}) at offset {offset}");
        }

        return length > 0 ? encoding.GetString(_buffer.Slice(checked((int)fix.Value), length)).TrimEnd('\0') : string.Empty;
    }

    public bool TryGetPointerFix(long offset, out PointerFix pointerFix) =>
        context.CurrentDatabaseMetadata.Fixes.TryGetValue(offset, out pointerFix);

    public int GetSize(Type type) => options.GetTypeSize(type, context);
}

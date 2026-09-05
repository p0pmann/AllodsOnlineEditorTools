using System.Buffers.Binary;
using System.IO.Compression;
using System.Text;

namespace AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

/// <summary>Value-only UTF-16 localization table used by the 17.x client.</summary>
public sealed class LocalizationTable
{
    private readonly byte[] _data;
    private readonly int _pool;
    public int Count { get; }

    public LocalizationTable(byte[] data)
    {
        _data = data;
        if (data.Length < 28 || ReadUInt(0) != 0xCAFB0185 || ReadUInt(4) != 0)
        {
            throw new InvalidDataException("Invalid localization header");
        }

        var words = ReadLong(8);
        if (words < 0 || words % 2 != 0 || words > (data.Length - 28) / 8)
        {
            throw new InvalidDataException("Invalid localization directory size");
        }

        Count = checked((int)(words / 2));
        var tail = 16 + Count * 16;
        _pool = tail + 12;
        if (ReadUInt(tail) != 1 || ReadLong(tail + 4) != data.Length - _pool)
        {
            throw new InvalidDataException("Invalid localization pool");
        }
    }

    public static LocalizationTable Load(string path)
    {
        using var source = File.OpenRead(path);
        using var inflater = new ZLibStream(source, CompressionMode.Decompress);
        using var data = new MemoryStream();
        inflater.CopyTo(data);
        return new LocalizationTable(data.ToArray());
    }

    public string GetText(long index)
    {
        if (index < 0 || index >= Count)
        {
            throw new InvalidDataException($"Invalid localization index {index}");
        }

        var slot = 16 + checked((int)index) * 16;
        var chars = ReadLong(slot);
        var offset = ReadLong(slot + 8);
        var poolLength = _data.Length - _pool;
        if (offset < 0 || offset > poolLength || chars < 0 || chars > (poolLength - offset) / 2)
        {
            throw new InvalidDataException($"Localization entry {index} exceeds its pool");
        }

        return Encoding.Unicode.GetString(_data, _pool + (int)offset, (int)chars * 2);
    }

    private uint ReadUInt(int offset) => BinaryPrimitives.ReadUInt32LittleEndian(_data.AsSpan(offset, 4));
    private long ReadLong(int offset) => BinaryPrimitives.ReadInt64LittleEndian(_data.AsSpan(offset, 8));
}

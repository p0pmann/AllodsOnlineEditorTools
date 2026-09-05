using System.Buffers.Binary;
using System.Text;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace ClientResources.Tests;

[TestFixture]
public class LocalizationTableTests
{
    [Test]
    public void LocalizedTextUsesTableAndProducesSidecarReference()
    {
        var text = Encoding.Unicode.GetBytes("Hello світ");
        var bytes = new byte[44 + text.Length];
        BinaryPrimitives.WriteUInt32LittleEndian(bytes, 0xCAFB0185);
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(8), 2);
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(16), text.Length / 2);
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(32), 1);
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(36), text.Length);
        text.CopyTo(bytes, 44);
        var table = new LocalizationTable(bytes);
        Assert.That(table.GetText(0), Is.EqualTo("Hello світ"));
        Assert.Throws<InvalidDataException>(() => table.GetText(1));
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, 8);
        context.Localization = table;
        string? captured = null;
        context.TextFileRead = (_, value) => captured = value;
        var reader = new BinaryStructReader(new byte[32], context, BinarySerializerOptions.Default);
        var reference = (TextFileRef)reader.ReadField(0, typeof(TextFileRef))!;
        Assert.That(reference.Name, Is.EqualTo("__localized/0.txt"));
        Assert.That(captured, Is.EqualTo("Hello світ"));
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(24), bytes.Length);
        Assert.Throws<InvalidDataException>(() => new LocalizationTable(bytes).GetText(0));
    }
}

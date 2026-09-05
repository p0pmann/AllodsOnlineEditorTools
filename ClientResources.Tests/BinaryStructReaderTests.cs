using System.Buffers.Binary;
using System.Text;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace ClientResources.Tests;

[TestFixture]
public class BinaryStructReaderTests
{
    public sealed class PaddedItem { [FieldOffset(0)] public int Value; }
    public sealed class ArrayHolder { [FieldOffset(0, ArrayStride = 16)] public PaddedItem[] Items = []; }

    [Test]
    public void UsesRecoveredArrayStrideRatherThanSerializedExtent()
    {
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, 8);
        context.CurrentDatabaseMetadata.Fixes.Add(0, new(PointerFix.FixType.Direct, false, 32));
        var bytes = new byte[64];
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(8), 32);
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(32), 17);
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(48), 49);
        var reader = new BinaryStructReader(bytes, context, BinarySerializerOptions.Default);
        var result = (ArrayHolder)reader.ReadObject(0, typeof(ArrayHolder));
        Assert.That(result.Items.Select(i => i.Value), Is.EqualTo(new[] { 17, 49 }));
    }

    [TestCase(7, true)]
    [TestCase(8, false)]
    [TestCase(1024, true)]
    public void RejectsMalformedVectors(long size, bool relocation)
    {
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, 8);
        if (relocation)
        {
            context.CurrentDatabaseMetadata.Fixes.Add(0, new(PointerFix.FixType.Direct, false, 32));
        }

        var bytes = new byte[64];
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(8), size);
        Assert.Throws<InvalidDataException>(() => ReadArray(bytes, context));
    }

    private static object? ReadArray(byte[] bytes, BinaryStructSerializerContext context)
    {
        var reader = new BinaryStructReader(bytes, context, BinarySerializerOptions.Default);
        return reader.ReadField(0, typeof(int[]));
    }

    [TestCase(4)]
    [TestCase(8)]
    public void StringLengthUsesDatabaseWordSize(int pointerSize)
    {
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, pointerSize);
        context.CurrentDatabaseMetadata.Fixes.Add(0, new(PointerFix.FixType.Direct, false, 32));
        var bytes = new byte[64];
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(pointerSize), 5);
        Encoding.UTF8.GetBytes("hello").CopyTo(bytes, 32);
        var reader = new BinaryStructReader(bytes, context, BinarySerializerOptions.Default);
        Assert.That(reader.ReadString(0), Is.EqualTo("hello"));
        Assert.That(reader.GetSize(typeof(string)), Is.EqualTo(pointerSize * 3));
    }

    [TestCase(false, false)]
    [TestCase(true, false)]
    [TestCase(false, true)]
    public void EmbeddedObjectsRequireOneMatchingRelocatedCopy(bool duplicate, bool mismatch)
    {
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, 8);
        context.TypeResolver = StructTypeResolver.FromTypes(typeof(TestEmbeddedChild));
        var metadata = context.CurrentDatabaseMetadata;
        metadata.Structs.Add(nameof(TestEmbeddedChild));
        metadata.Fixes.Add(0, new(PointerFix.FixType.Type, false, 0));
        metadata.Fixes.Add(128, new(PointerFix.FixType.Generic, false, 0));
        metadata.Fixes.Add(136, new(PointerFix.FixType.Direct, false, 300));
        metadata.Fixes.Add(256, new(PointerFix.FixType.Type, false, 0));
        var bytes = new byte[512];
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(56), 0x123456789);
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(72), 7);
        BinaryPrimitives.WriteInt64LittleEndian(bytes.AsSpan(144), 5);
        BinaryPrimitives.WriteInt32LittleEndian(bytes.AsSpan(160), mismatch ? 8 : 7);
        Encoding.UTF8.GetBytes("hello").CopyTo(bytes, 300);
        if (duplicate)
        {
            bytes.AsSpan(128, 40).CopyTo(bytes.AsSpan(192));
            metadata.Fixes.Add(192, new(PointerFix.FixType.Generic, false, 0));
            metadata.Fixes.Add(200, new(PointerFix.FixType.Direct, false, 300));
        }
        if (duplicate || mismatch)
        {
            Assert.Throws<InvalidDataException>(() => ReadEmbedded(bytes, context));
        }
        else
        {
            Assert.That(ReadEmbedded(bytes, context).Child.Text, Is.EqualTo("hello"));
        }
    }

    private static TestEmbeddedHolder ReadEmbedded(byte[] bytes, BinaryStructSerializerContext context)
    {
        var reader = new BinaryStructReader(bytes, context, BinarySerializerOptions.Default);
        return (TestEmbeddedHolder)reader.ReadObject(0, typeof(TestEmbeddedHolder));
    }
}

public sealed class TestEmbeddedChild
{
    [FieldOffset(8)] public string Text = string.Empty;
    [FieldOffset(32)] public int Number;
}

public sealed class TestEmbeddedHolder
{
    [FieldOffset(40, EmbeddedVirtual = true)] public TestEmbeddedChild Child = new();
}

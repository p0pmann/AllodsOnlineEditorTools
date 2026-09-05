using System.Buffers.Binary;
using System.IO.Compression;
using System.Text;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClientResources.Tests;

[TestFixture]
public class BinaryClient17Tests
{
    [TestCase(false)]
    [TestCase(true)]
    public void LoadsX64RelocationsAndOptionalResourceIdDirectories(bool shortDirectory)
    {
        using var payload = new MemoryStream();
        using var writer = new BinaryWriter(payload, Encoding.UTF8, leaveOpen: true);
        writer.Write(Convert.FromHexString("C4022E59730400008501FBCA"));
        var metadataSize = shortDirectory ? 40 : 56;
        writer.Write(2);
        writer.Write((long)metadataSize);
        for (var i = 0; i < (shortDirectory ? 3 : 5); i++)
        { writer.Write(8); writer.Write(0); }
        writer.Write(16);
        writer.Write(0);
        writer.Write(123L);
        writer.Write(3);
        writer.Write(128L);
        writer.Write(new byte[128]);
        writer.Write(4);
        writer.Write(6L);
        for (var tag = 0; tag < 6; tag++)
        { writer.Write(8L * tag + tag); writer.Write(64L + tag); }
        writer.Write(5);
        writer.Write(0L);
        writer.Write(6);
        writer.Write(0L);
        writer.Flush();
        var path = Path.Combine(Path.GetTempPath(), $"allods-test-{Guid.NewGuid():N}.bin");
        try
        {
            using (var file = File.Create(path))
            using (var compressed = new ZLibStream(file, CompressionLevel.Fastest))
            {
                compressed.Write(payload.ToArray());
            }

            var database = DatabaseLoader.LoadDatabases(path, NullLoggerFactory.Instance).Single().Value;
            Assert.That(database.Metadata.PointerSize, Is.EqualTo(8));
            Assert.That(database.Metadata.ResourceSystemVersion, Is.EqualTo(123));
            var types = new[] { PointerFix.FixType.DbIdRef, PointerFix.FixType.DbIdRef, PointerFix.FixType.Unresolved,
                PointerFix.FixType.Direct, PointerFix.FixType.Type, PointerFix.FixType.Generic };
            for (var i = 0; i < types.Length; i++)
            {
                Assert.That(database.Metadata.Fixes[i * 8], Is.EqualTo(new PointerFix(types[i], i == 1, 64 + i)));
            }
            var paths = DatabaseLoader.LoadPathMetadata(path, NullLoggerFactory.Instance).Single().Value;
            Assert.That(paths.Version, Is.EqualTo(database.Metadata.Version));
            Assert.That(paths.Fixes.Keys, Is.EquivalentTo(new long[] { 32 }));
            Assert.That(paths.Fixes[32], Is.EqualTo(database.Metadata.Fixes[32]));
            Assert.That(DatabaseLoader.LoadPathMetadata(path, NullLoggerFactory.Instance, ["unrelated.bin"]), Is.Empty);
        }
        finally { File.Delete(path); }
    }

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

    [Test]
    public void UnnamedRootsGetStablePathsAndNamedRootsArePreserved()
    {
        var context = TestContexts.TestContext(FileRefKind.PakFileRef, 8);
        var metadata = context.CurrentDatabaseMetadata;
        metadata.Fixes.Add(0, new(PointerFix.FixType.Type, false, 0));
        metadata.Fixes.Add(64, new(PointerFix.FixType.Type, false, 0));
        metadata.Fixes.Add(96, new(PointerFix.FixType.Generic, false, 0));
        metadata.DbId2File.Add(0, "known.xdb");
        metadata.File2DbId.Add("known.xdb", 0);
        var db = new BinDatabase(metadata, new byte[128]);
        DatabaseExport.AssignMissingPaths(db, "pack.bin");
        DatabaseExport.AssignMissingPaths(db, "pack.bin");
        Assert.That(metadata.DbId2File[0], Is.EqualTo("known.xdb"));
        Assert.That(metadata.DbId2File[64], Is.EqualTo("__generated/pack/offset-64.xdb"));
        Assert.That(metadata.DbId2File.ContainsKey(96), Is.False);
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

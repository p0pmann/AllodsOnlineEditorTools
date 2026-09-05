using System.IO.Compression;
using System.Text;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;
using Microsoft.Extensions.Logging.Abstractions;

namespace ClientResources.Tests;

[TestFixture]
public class DatabaseLoaderTests
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
}

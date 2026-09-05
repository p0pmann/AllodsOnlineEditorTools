using System.Buffers.Binary;
using System.IO.Compression;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace ClientResources.Tests;

[TestFixture]
public class ResourcePathCatalogTests
{
    private static DatabaseMetadata Metadata(int pointerSize = 8, HashSet<int>? payloadOffsets = null) => new()
    {
        PointerSize = pointerSize,
        Version = [],
        ResourceSystemVersion = 0,
        Structs = [],
        DbId2File = new Dictionary<long, string>(),
        File2DbId = new Dictionary<string, long>(),
        DbId2ResId = new Dictionary<long, int>(),
        ResId2DbId = new Dictionary<int, long>(),
        ObjId2DbId = new Dictionary<int, long>(),
        DbId2ObjId = new Dictionary<long, int>(),
        Fixes = new Dictionary<long, PointerFix>(),
        Packs = ["test.pak"],
        PakFileRefOffsets = payloadOffsets,
    };
    private static void Root(DatabaseMetadata metadata, long offset, int? id, string? path = null, string type = "Example")
    {
        if (!metadata.Structs.Contains(type))
        {
            metadata.Structs.Add(type);
        }

        metadata.Fixes.Add(offset, new(PointerFix.FixType.Type, false, metadata.Structs.IndexOf(type)));
        if (id is { } resourceId)
        { metadata.DbId2ResId.Add(offset, resourceId); metadata.ResId2DbId.TryAdd(resourceId, offset); }
        if (path != null)
        { metadata.DbId2File.Add(offset, path); metadata.File2DbId.Add(path, offset); }
    }
    private static ResourcePathCatalog Catalog(DatabaseMetadata reference, string name = "pack.bin") => new(new Dictionary<string, DatabaseMetadata> { [name] = reference });

    private static PathRecoveryReport RecoverPayloads(DatabaseMetadata reference, BinDatabase target, params string[] payloads)
    {
        var directory = Path.Combine(Path.GetTempPath(), Guid.NewGuid().ToString());
        Directory.CreateDirectory(directory);
        try
        {
            using (var archive = ZipFile.Open(Path.Combine(directory, "test.pak"), ZipArchiveMode.Create))
            {
                foreach (var path in payloads)
                {
                    archive.CreateEntry(path);
                }
            }
            return Catalog(reference).RestoreMissingPaths(new Dictionary<string, BinDatabase> { ["pack.bin"] = target }, PacksRegistry.Load(directory),
                StructTypeResolver.FromTypes(typeof(PayloadModels.Example), typeof(PayloadModels.Texture))).Single();
        }
        finally { Directory.Delete(directory, true); }
    }

    private static void Payload(byte[] data, int offset, int pointerSize, int entry, int pack = 0)
    {
        if (pointerSize == 4)
        {
            BinaryPrimitives.WriteInt32LittleEndian(data.AsSpan(offset + 3 * pointerSize), pack);
            BinaryPrimitives.WriteInt32LittleEndian(data.AsSpan(offset + 4 * pointerSize), entry);
        }
        else
        {
            BinaryPrimitives.WriteInt64LittleEndian(data.AsSpan(offset + 3 * pointerSize), pack);
            BinaryPrimitives.WriteInt64LittleEndian(data.AsSpan(offset + 4 * pointerSize), entry);
        }
    }

    [TestCase(4)]
    [TestCase(8)]
    public void RecoversCataloguedPayloadDescriptorsWithoutResourceIds(int pointerSize)
    {
        var reference = Metadata(4);
        var target = Metadata(pointerSize, [16]);
        Root(reference, 32, null, "Textures/Example.(Texture).xdb", "Texture");
        Root(target, 0, null, type: "Texture");
        var data = new byte[128];
        Payload(data, 16, pointerSize, 0);
        var report = RecoverPayloads(reference, new(target, data), "/Textures/Example.(Texture).hi.bin");
        Assert.Multiple(() =>
        {
            Assert.That(report.Restored, Is.EqualTo(1));
            Assert.That(report.PayloadMatches, Is.EqualTo(1));
            Assert.That(report.Unmatched, Is.Zero);
            Assert.That(target.DbId2File[0], Is.EqualTo("Textures/Example.(Texture).xdb"));
        });
    }

    [TestCase("Missing.bin", "Example", 0, 0)]
    [TestCase("Known.bin", "DifferentType", 0, 0)]
    [TestCase("Known.bin", "Example", 0, 1)]
    [TestCase("Known.bin", "Example", 1, 0)]
    [TestCase("Known.bin", "Example", -1, 0)]
    public void UnverifiedOrUnavailablePayloadsRemainUnmatched(string payload, string type, int entry, int pack)
    {
        var reference = Metadata();
        var target = Metadata(payloadOffsets: [16]);
        Root(reference, 32, null, "Known.xdb");
        Root(target, 0, null, type: type);
        var data = new byte[128];
        Payload(data, 16, 8, entry, pack);
        var report = RecoverPayloads(reference, new(target, data), payload);
        Assert.That(report.Unmatched, Is.EqualTo(1));
        Assert.That(target.DbId2File, Is.Empty);
    }

    [Test]
    public void PayloadOutsideTheVerifiedFieldsCannotNameThePrecedingRoot()
    {
        var reference = Metadata();
        var target = Metadata(payloadOffsets: [192]);
        Root(reference, 16, null, "Known.xdb");
        Root(target, 0, null);
        var data = new byte[256];
        Payload(data, 192, 8, 0);
        var report = RecoverPayloads(reference, new(target, data), "Known.bin");
        Assert.That(report.Unmatched, Is.EqualTo(1));
        Assert.That(target.DbId2File, Is.Empty);
    }

    [Test]
    public void RejectsAmbiguousPayloadsAndSharedDescriptorPaths()
    {
        var reference = Metadata();
        var target = Metadata(payloadOffsets: [16, 64, 144, 272]);
        Root(reference, 16, null, "One.xdb");
        Root(reference, 32, null, "Two.xdb");
        Root(reference, 48, null, "Shared.xdb");
        Root(target, 0, null);
        Root(target, 128, null);
        Root(target, 256, null);
        var data = new byte[384];
        Payload(data, 16, 8, 0);
        Payload(data, 64, 8, 1);
        Payload(data, 144, 8, 2);
        Payload(data, 272, 8, 2);
        var report = RecoverPayloads(reference, new(target, data), "One.bin", "Two.bin", "Shared.bin");
        Assert.That(report.PathConflicts, Is.EqualTo(3));
        Assert.That(report.Unmatched, Is.Zero);
        Assert.That(target.DbId2File, Is.Empty);
    }

    [Test]
    public void PayloadEvidenceCannotOverrideAcceptedOrRejectedResourceIdMatches()
    {
        var reference = Metadata();
        var target = Metadata(payloadOffsets: [16, 144]);
        Root(reference, 16, 1, "ById.xdb");
        Root(reference, 32, 2, "ChangedType.xdb", "PreviousType");
        Root(reference, 48, null, "Payload.xdb");
        Root(target, 0, 1);
        Root(target, 128, 2);
        var data = new byte[256];
        Payload(data, 16, 8, 0);
        Payload(data, 144, 8, 0);
        var report = RecoverPayloads(reference, new(target, data), "Payload.bin");
        Assert.That(report.Restored, Is.EqualTo(1));
        Assert.That(report.PayloadMatches, Is.Zero);
        Assert.That(report.TypeMismatches, Is.EqualTo(1));
        Assert.That(target.DbId2File[0], Is.EqualTo("ById.xdb"));
        Assert.That(target.DbId2File.ContainsKey(128), Is.False);
    }

    [Test]
    public void RestoresByResourceIdAcrossWordSizesAndUpdatesPointerPaths()
    {
        var reference = Metadata(4);
        var target = Metadata();
        Root(reference, 16, 123, "Mechanics/Example.xdb");
        Root(target, 64, 123);
        target.Fixes.Add(0, new(PointerFix.FixType.DbIdRef, false, 64));
        var report = Catalog(reference).RestoreMissingPaths(target, "PACK.BIN");
        DatabaseExport.AssignMissingPaths(new(target, new byte[128]), "pack.bin");
        var context = new BinaryStructSerializerContext
        { CurrentDatabaseMetadata = target, MainDatabaseMetadata = target, TypeResolver = StructTypeResolver.FromTypes(), FileRefKind = FileRefKind.PakFileRef };
        var reader = new BinaryStructReader(new byte[128], context, BinarySerializerOptions.Default);
        var pointer = (ResourcePointer)reader.ReadField(0, typeof(ResourcePointer))!;
        Assert.Multiple(() =>
        {
            Assert.That(report.Restored, Is.EqualTo(1));
            Assert.That(target.DbId2File[64], Is.EqualTo("Mechanics/Example.xdb"));
            Assert.That(target.File2DbId["Mechanics/Example.xdb"], Is.EqualTo(64));
            Assert.That(pointer.Href, Is.EqualTo("Mechanics/Example.xdb"));
            Assert.That(reference.DbId2File[16], Is.EqualTo("Mechanics/Example.xdb"));
        });
    }

    [Test]
    public void PreservesEmbeddedNamesAndReplacesBlankEntries()
    {
        var reference = Metadata(4);
        var target = Metadata();
        Root(reference, 16, 1, "Old.xdb");
        Root(reference, 32, 2, "Restored.xdb");
        Root(target, 64, 1, "Current.xdb");
        Root(target, 128, 2, "");
        var catalog = Catalog(reference);
        Assert.That(catalog.RestoreMissingPaths(target, "pack.bin").Restored, Is.EqualTo(1));
        Assert.Multiple(() =>
        {
            Assert.That(target.DbId2File[64], Is.EqualTo("Current.xdb"));
            Assert.That(target.DbId2File[128], Is.EqualTo("Restored.xdb"));
            Assert.That(target.File2DbId.ContainsKey(""), Is.False);
            Assert.That(catalog.RestoreMissingPaths(target, "pack.bin").Restored, Is.Zero);
        });
    }

    [Test]
    public void ObjectIdsAndOffsetsAreNotCrossVersionIdentities()
    {
        var reference = Metadata(4);
        var target = Metadata();
        Root(reference, 64, 123, "Wrong.xdb");
        Root(target, 64, null);
        target.ObjId2DbId!.Add(123, 64);
        target.DbId2ObjId!.Add(64, 123);
        Assert.That(Catalog(reference).RestoreMissingPaths(target, "pack.bin").Unmatched, Is.EqualTo(1));
        DatabaseExport.AssignMissingPaths(new(target, []), "pack.bin");
        Assert.That(target.DbId2File[64], Is.EqualTo("__generated/pack/obj-123.xdb"));
    }

    [Test]
    public void RejectsAmbiguousIdsInEitherDatabase()
    {
        var reference = Metadata();
        var target = Metadata();
        Root(reference, 16, 1, "One.xdb");
        Root(reference, 32, 1, "Other.xdb");
        Root(reference, 48, 2, "Two.xdb");
        Root(target, 64, 1);
        Root(target, 128, 2);
        Root(target, 192, 2);
        var report = Catalog(reference).RestoreMissingPaths(target, "pack.bin");
        Assert.Multiple(() => { Assert.That(report.AmbiguousIds, Is.EqualTo(3)); Assert.That(target.DbId2File, Is.Empty); });
    }

    [Test]
    public void RequiresSameDatabaseAndResourceType()
    {
        var reference = Metadata();
        var target = Metadata();
        Root(reference, 16, 1, "Reference.xdb", "Before");
        Root(target, 64, 1, type: "After");
        var catalog = Catalog(reference);
        Assert.Multiple(() =>
        {
            Assert.That(catalog.RestoreMissingPaths(target, "Maps_Remort.bin").Unmatched, Is.EqualTo(1));
            Assert.That(catalog.RestoreMissingPaths(target, "pack.bin").TypeMismatches, Is.EqualTo(1));
            Assert.That(target.DbId2File, Is.Empty);
        });
    }

    [Test]
    public void RejectsCollidingOutputPathsWithoutChoosingAnArbitraryWinner()
    {
        var reference = Metadata();
        var target = Metadata();
        Root(reference, 16, 1, "Dir/Name.xdb");
        Root(reference, 32, 2, "dir\\name.jdb");
        Root(reference, 48, 3, "Existing.xdb");
        Root(target, 64, 1);
        Root(target, 128, 2);
        Root(target, 192, 3);
        Root(target, 256, 4, "existing.xdb");
        Assert.That(Catalog(reference).RestoreMissingPaths(target, "pack.bin").PathConflicts, Is.EqualTo(3));
        Assert.That(target.DbId2File.Keys, Is.EquivalentTo(new long[] { 256 }));
    }

    [TestCase("../escape.xdb")]
    [TestCase("/absolute.xdb")]
    [TestCase("C:\\escape.xdb")]
    [TestCase("Dir/../escape.xdb")]
    [TestCase("Dir /alias.xdb")]
    public void InvalidReferenceNamesFallBack(string path)
    {
        var reference = Metadata();
        var target = Metadata();
        Root(reference, 16, 1, path);
        Root(target, 64, 1);
        Assert.That(Catalog(reference).RestoreMissingPaths(target, "pack.bin").InvalidPaths, Is.EqualTo(1));
        DatabaseExport.AssignMissingPaths(new(target, []), "pack.bin");
        Assert.That(target.DbId2File[64], Is.EqualTo("__generated/pack/offset-64.xdb"));
    }

    [Test]
    public void UnnamedX86RootsAlsoReceiveFallbackPaths()
    {
        var metadata = Metadata(4);
        Root(metadata, 16, null, "");
        DatabaseExport.AssignMissingPaths(new(metadata, []), "pack.bin");
        Assert.That(metadata.DbId2File[16], Is.EqualTo("__generated/pack/offset-16.xdb"));
    }

    [Test]
    public void PreventsRestoredPathsFromCollidingAcrossDatabases()
    {
        var reference1 = Metadata();
        var reference2 = Metadata();
        var target1 = Metadata();
        var target2 = Metadata();
        Root(reference1, 16, 1, "Same.xdb");
        Root(reference2, 16, 2, "same.xdb");
        Root(target1, 64, 1);
        Root(target2, 64, 2);
        var catalog = new ResourcePathCatalog(new Dictionary<string, DatabaseMetadata> { ["pack.bin"] = reference1, ["Map.bin"] = reference2 });
        var targets = new Dictionary<string, DatabaseMetadata> { ["pack.bin"] = target1, ["Map.bin"] = target2 };
        Assert.That(catalog.RestoreMissingPaths(targets).Sum(r => r.PathConflicts), Is.EqualTo(2));
        Assert.That(target1.DbId2File, Is.Empty);
        Assert.That(target2.DbId2File, Is.Empty);
        target2.DbId2File.Add(64, "Same.xdb");
        target2.File2DbId.Add("Same.xdb", 64);
        Assert.That(catalog.RestoreMissingPaths(targets).Sum(r => r.PathConflicts), Is.EqualTo(1));
    }
}

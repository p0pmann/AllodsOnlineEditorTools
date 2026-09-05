using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin.Database;

namespace ClientResources.Tests;

[TestFixture]
public class DatabaseExportTests
{
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
        Assert.That(metadata.DbId2File[64], Is.EqualTo("_unnamed/Unknown/blob_40.xdb"));
        Assert.That(metadata.DbId2File.ContainsKey(96), Is.False);
    }
}

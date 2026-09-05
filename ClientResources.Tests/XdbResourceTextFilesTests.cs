using System.Xml.Linq;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;

namespace ClientResources.Tests;

[TestFixture]
public class XdbResourceTextFilesTests
{
    public sealed class TextItem
    {
        public TextFileRef name = new("__localized/2.txt");
    }

    public sealed class TextDocument
    {
        public TextFileRef name = new("__localized/1.txt");
        public TextFileRef description = new("");
        public TextItem[] items = [new(), new()];
    }

    [TestCase("Mechanics/PlatinumCoin.xdb", "Mechanics/", "PlatinumCoin")]
    [TestCase("_unnamed/Example/id_123.xdb", "_unnamed/Example/", "id_123")]
    public void LocalizedTextIsWrittenBesideItsOwnerWithDistinctNamesForRepeatedFields(string resourcePath, string directory, string stem)
    {
        var texts = new Dictionary<string, string> { ["__localized/1.txt"] = "Platinum coin", ["__localized/2.txt"] = "Світ & <text>" };
        var sidecars = new XdbResourceTextFiles(resourcePath, source => texts.GetValueOrDefault(source));
        var serializer = new XdbStructSerializer(XdbStructSerializerOptions.Default, new ResourceSerializationContext { TextFileHref = sidecars.GetHref });
        var root = XDocument.Parse(serializer.SerializeResource(new TextDocument(), 123)).Root!;
        Assert.That(root.Element("name")!.Attribute("href")!.Value, Is.EqualTo(stem + ".Name.txt"));
        Assert.That(root.Element("description")!.Attribute("href")!.Value, Is.Empty);
        Assert.That(root.Element("items")!.Elements("Item").Select(e => e.Element("name")!.Attribute("href")!.Value),
            Is.EqualTo(new[] { stem + ".Name2.txt", stem + ".Name3.txt" }));
        Assert.That(sidecars.Files.Count, Is.EqualTo(3));
        Assert.That(sidecars.Files[directory + stem + ".Name.txt"], Is.EqualTo("Platinum coin"));
        Assert.That(sidecars.Files[directory + stem + ".Name3.txt"], Is.EqualTo("Світ & <text>"));
    }

    [Test]
    public void ExistingTextPathsArePreservedWhenNoLocalizedContentIsAvailable()
    {
        var sidecars = new XdbResourceTextFiles("Example.xdb", _ => null);
        Assert.That(sidecars.GetHref("name", "Texts/Original.txt"), Is.EqualTo("/Texts/Original.txt"));
        Assert.That(sidecars.Files, Is.Empty);
    }

    [Test]
    public void FieldNamesCannotEscapeTheOwnerDirectory()
    {
        var sidecars = new XdbResourceTextFiles("Dir/Example.xdb", _ => "text");
        var href = sidecars.GetHref("../name", "__localized/1.txt");
        Assert.That(href, Is.EqualTo("Example.___name.txt"));
        Assert.That(sidecars.Files.Keys, Is.EqualTo(new[] { "Dir/Example.___name.txt" }));
    }
}

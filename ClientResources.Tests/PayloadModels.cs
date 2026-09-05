using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;

namespace ClientResources.Tests.PayloadModels;

public class Example
{
    [FieldOffset(16)] public FileRef First;
    [FieldOffset(64)] public FileRef Second;
}

public class Texture
{
    [FieldOffset(16)] public FileRef BinaryFile;
}

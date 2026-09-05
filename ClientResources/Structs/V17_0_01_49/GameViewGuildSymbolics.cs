// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49;

[StructSize(104)]
[XdbName("GameViewGuildSymbolics")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewGuildSymbolics
{
    [FieldOffset(40)] public FileRef @binaryFile;
    [FieldOffset(80)] public ResourcePointer @maskTexture;
    [FieldOffset(88)] public int @primaryColor;
    [FieldOffset(92)] public int @secondaryColor;
    [FieldOffset(96)] public int @texturePersistentId;
}

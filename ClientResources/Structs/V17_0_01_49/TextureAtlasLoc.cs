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

[StructSize(120)]
[XdbName("TextureAtlasLoc")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TextureAtlasLoc
{
    [FieldOffset(40)] public ResourcePointer @combinedTexture;
    [FieldOffset(48, ArrayStride = 48)] public Layouts.@s_21f370[] @sources;
    [FieldOffset(88)] public string @locName;
    [FieldOffset(112)] public ResourcePointer @source;
}

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

[StructSize(72)]
[XdbName("BakedTexture")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BakedTexture
{
    [FieldOffset(36)] public Layouts.@s_bd0010 @rect;
    [FieldOffset(56)] public ResourcePointer @texture;
    [FieldOffset(64)] public bool @doBlend;
}

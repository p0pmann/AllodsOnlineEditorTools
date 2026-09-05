// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(72)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_a68410
{
    [FieldOffset(4)] public Layouts.@s_a68500 @Position;
    [FieldOffset(20)] public Layouts.@s_a68580 @Rotation;
    [FieldOffset(36)] public Layouts.@s_a68650 @Scale;
    [FieldOffset(48)] public ResourcePointer @StaticObjectTemplate;
    [FieldOffset(56)] public NullablePointer @data;
    [FieldOffset(64)] public Layouts.@s_a686a0 @shadowsAndLightningSettings;
}

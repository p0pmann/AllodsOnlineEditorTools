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

[SerializedExtent(73)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_aa3280
{
    [FieldOffset(4)] public Layouts.@s_a9f400 @ColorInfo;
    [FieldOffset(20)] public Vector3 @Position;
    [FieldOffset(32)] public Quaternion @Rotation;
    [FieldOffset(48)] public float @Scale;
    [FieldOffset(56)] public ResourcePointer @StaticObjectTemplate;
    [FieldOffset(64)] public NullablePointer @data;
    [FieldOffset(72)] public bool @useManualColor;
}

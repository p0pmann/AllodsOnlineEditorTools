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

[SerializedExtent(206)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cca220
{
    [FieldOffset(4)] public int @ambientColor;
    [FieldOffset(8)] public ResourcePointer @animation;
    [FieldOffset(16)] public Layouts.@s_cc7960 @color0;
    [FieldOffset(44)] public Layouts.@s_cc7960 @color1;
    [FieldOffset(72)] public Layouts.@s_cc7960 @color2;
    [FieldOffset(100)] public float @colorFactor;
    [FieldOffset(104, ArrayStride = 32)] public Layouts.@s_cc7760[] @controllers;
    [FieldOffset(136, ArrayStride = 8)] public NullablePointer[] @effects;
    [FieldOffset(168)] public float @fovFactor;
    [FieldOffset(176)] public ResourcePointer @geometry;
    [FieldOffset(184)] public float @shift;
    [FieldOffset(188)] public Vector3 @worldCoord;
    [FieldOffset(200)] public float @yaw;
    [FieldOffset(204)] public bool @show;
    [FieldOffset(205)] public bool @useWorldCoord;
}

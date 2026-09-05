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

[SerializedExtent(145)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_b685e0
{
    [FieldOffset(4)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(28)] public int @areaId;
    [FieldOffset(32)] public NullablePointer @areaInfo;
    [FieldOffset(40)] public Layouts.@s_2106e0 @blob;
    [FieldOffset(56, ArrayStride = 28)] public Layouts.@s_b63450[] @edges;
    [FieldOffset(88)] public string @name;
    [FieldOffset(112, ArrayStride = 4)] public int[] @portals;
    [FieldOffset(144)] public bool @useOcclusionTest;
}

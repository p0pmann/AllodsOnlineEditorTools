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

[SerializedExtent(92)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_b68900
{
    [FieldOffset(4)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(28)] public Layouts.@s_2106e0 @blob;
    [FieldOffset(40, ArrayStride = 28)] public Layouts.@s_b63450[] @edges;
    [FieldOffset(72)] public int @leftArea;
    [FieldOffset(76)] public Vector3 @normal;
    [FieldOffset(88)] public int @rightArea;
}

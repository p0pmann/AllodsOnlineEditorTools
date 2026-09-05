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

[SerializedExtent(68)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17dbae0
{
    [FieldOffset(8, ArrayStride = 12)] public Vector3[] @points;
    [FieldOffset(40)] public string @scriptID;
    [FieldOffset(64)] public float @yaw;
}

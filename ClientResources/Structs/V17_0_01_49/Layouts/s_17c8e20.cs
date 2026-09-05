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

[SerializedExtent(53)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17c8e20
{
    [FieldOffset(4)] public float @distance;
    [FieldOffset(8)] public float @pitch;
    [FieldOffset(12)] public float @roll;
    [FieldOffset(16)] public double @x;
    [FieldOffset(24)] public double @y;
    [FieldOffset(32)] public float @yaw;
    [FieldOffset(40)] public double @z;
    [FieldOffset(52)] public bool @setBeforeRunning;
}

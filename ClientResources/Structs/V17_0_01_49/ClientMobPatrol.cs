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

[SerializedExtent(140)]
[XdbName("ClientMobPatrol")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ClientMobPatrol
{
    [FieldOffset(48, ArrayStride = 12)] public Layouts.@s_18e1f60[] @links;
    [FieldOffset(80)] public Vector3 @position;
    [FieldOffset(96, ArrayStride = 28)] public Layouts.@s_18e2080[] @route;
    [FieldOffset(128)] public ResourcePointer @visualMob;
    [FieldOffset(136)] public float @yaw;
}

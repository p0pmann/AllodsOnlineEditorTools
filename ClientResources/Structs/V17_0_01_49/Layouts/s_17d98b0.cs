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

[SerializedExtent(69)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17d98b0
{
    [FieldOffset(8)] public ResourcePointer @device;
    [FieldOffset(16)] public Vector3 @offset;
    [FieldOffset(32)] public string @scriptID;
    [FieldOffset(56)] public int @staticObjectIndex;
    [FieldOffset(60)] public int @visualState;
    [FieldOffset(64)] public float @yaw;
    [FieldOffset(68)] public bool @isTracePositionToGround;
}

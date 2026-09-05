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

[SerializedExtent(256)]
[XdbName("GameViewActionCannonFire")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCannonFire
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public ResourcePointer @cannonData;
    [FieldOffset(168)] public string @cannonID;
    [FieldOffset(192)] public float @flyTime;
    [FieldOffset(200)] public ResourcePointer @spell;
    [FieldOffset(208)] public Vector3 @target;
    [FieldOffset(224, ArrayStride = 24)] public string[] @targetID;
}

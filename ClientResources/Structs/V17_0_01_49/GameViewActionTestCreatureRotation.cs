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

[SerializedExtent(280)]
[XdbName("GameViewActionTestCreatureRotation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionTestCreatureRotation
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @creature;
    [FieldOffset(188)] public int @afterConvulsionAngle;
    [FieldOffset(192)] public Layouts.@s_17be1b0 @convulsion;
    [FieldOffset(212)] public int @convulsionTime;
    [FieldOffset(216)] public int @durationTime;
    [FieldOffset(224, ArrayStride = 44)] public Layouts.@s_17be120[] @points;
    [FieldOffset(256)] public Vector3 @startPosition;
    [FieldOffset(268)] public Vector3 @startRotation;
}

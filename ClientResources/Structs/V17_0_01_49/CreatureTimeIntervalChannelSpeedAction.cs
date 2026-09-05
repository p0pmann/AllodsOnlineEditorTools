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

[SerializedExtent(124)]
[XdbName("CreatureTimeIntervalChannelSpeedAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureTimeIntervalChannelSpeedAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(76)][EnumRef(typeof(Enums.@e_1733130))] public int @channel;
    [FieldOffset(80)] public string @specialController;
    [FieldOffset(108)] public float @endSpeed;
    [FieldOffset(112)] public int @endTime;
    [FieldOffset(116)] public float @frozenSpeed;
    [FieldOffset(120)] public float @startSpeed;
}

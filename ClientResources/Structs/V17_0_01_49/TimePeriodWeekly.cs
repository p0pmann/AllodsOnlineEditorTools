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

[SerializedExtent(80)]
[XdbName("timeperiod.TimePeriodWeekly")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TimePeriodWeekly
{
    [FieldOffset(48)] public long @duration;
    [FieldOffset(68)] public int @day;
    [FieldOffset(72)] public int @hour;
    [FieldOffset(76)] public int @minute;
}

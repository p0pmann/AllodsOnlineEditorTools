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

[SerializedExtent(88)]
[XdbName("timetables.TimeEntryHourlyResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TimeEntryHourlyResource
{
    [FieldOffset(52)] public int @minute;
    [FieldOffset(56)] public int @periodDivisor;
    [FieldOffset(64)] public string @sysType;
}

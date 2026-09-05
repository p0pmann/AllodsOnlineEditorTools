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

[SerializedExtent(96)]
[XdbName("timetables.TimeEntryYearlyResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TimeEntryYearlyResource
{
    [FieldOffset(52)] public int @day;
    [FieldOffset(56)] public int @hour;
    [FieldOffset(60)] public int @minute;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_15bd890))] public int @month;
    [FieldOffset(72)] public string @sysType;
}

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

[StructSize(416)]
[XdbName("avatarPopulation.service.impl.matchMakingImpl.eventType.lfg.LFGIslandEventType")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LFGIslandEventType
{
    [FieldOffset(36)] public int @activeEventJoinPeriod;
    [FieldOffset(40)] public int @capacity;
    [FieldOffset(48)] public ResourcePointer @category;
    [FieldOffset(56, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(88)] public TextFileRef @description;
    [FieldOffset(120)] public TextFileRef @difficulty;
    [FieldOffset(152)][EnumRef(typeof(Enums.@e_1030b60))] public int @difficultyMode;
    [FieldOffset(156)] public float @immediatelyStartFactor;
    [FieldOffset(160)] public Layouts.@s_122d150 @inviteTimeout;
    [FieldOffset(184, ArrayStride = 8)] public NullablePointer[] @joinConditions;
    [FieldOffset(216)] public int @maxVisitsPerDay;
    [FieldOffset(220)] public int @maxVisitsPerWeek;
    [FieldOffset(224)] public NullablePointer @minAvatarLevel;
    [FieldOffset(232)] public int @minTeamSize;
    [FieldOffset(240)] public TextFileRef @name;
    [FieldOffset(272, ArrayStride = 80)] public Layouts.@s_156c590[] @nameVars;
    [FieldOffset(304)][EnumRef(typeof(Enums.@e_f7e9e0))] public int @policy;
    [FieldOffset(312)] public NullablePointer @reward;
    [FieldOffset(320, ArrayStride = 8)] public NullablePointer[] @showPredicates;
    [FieldOffset(352)] public ResourcePointer @startTime;
    [FieldOffset(360)] public ResourcePointer @ticket;
    [FieldOffset(368)] public bool @allowQuickExit;
    [FieldOffset(369)] public bool @canDenyParticipation;
    [FieldOffset(370)] public bool @commonShard;
    [FieldOffset(371)] public bool @exclusive;
    [FieldOffset(372)] public bool @internal;
    [FieldOffset(373)] public bool @isHighPriority;
    [FieldOffset(380)] public int @maxServerProgress;
    [FieldOffset(384)] public ResourcePointer @requiredCurrency;
    [FieldOffset(392)] public ResourcePointer @requiredItem;
    [FieldOffset(400)] public bool @allowedAwayFromEvent;
}

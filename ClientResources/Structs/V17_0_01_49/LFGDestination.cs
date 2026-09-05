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

[StructSize(368)]
[XdbName("avatarPopulation.service.impl.lookingForGroupImpl.scheme.LFGDestination")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LFGDestination
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @additionalPredicates;
    [FieldOffset(72)] public ResourcePointer @category;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @departPredicates;
    [FieldOffset(112)] public TextFileRef @description;
    [FieldOffset(144)] public TextFileRef @difficulty;
    [FieldOffset(176)][EnumRef(typeof(Enums.@e_1030b60))] public int @difficultyMode;
    [FieldOffset(184)] public ResourcePointer @faction;
    [FieldOffset(192)] public Layouts.@s_122d150 @groupQueueTime;
    [FieldOffset(216)] public Layouts.@s_122d150 @groupStabilizationTime;
    [FieldOffset(240)] public ResourcePointer @instancedEvent;
    [FieldOffset(248)] public int @maxEventDuration;
    [FieldOffset(252)] public int @maxMembers;
    [FieldOffset(256)] public int @maxServerProgress;
    [FieldOffset(260)] public int @maxVisitsPerDay;
    [FieldOffset(264)] public int @maxVisitsPerWeek;
    [FieldOffset(268)] public int @minAvatarLvl;
    [FieldOffset(272)] public TextFileRef @name;
    [FieldOffset(304, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(336)] public ResourcePointer @requiredCurrency;
    [FieldOffset(344)] public ResourcePointer @requiredItem;
    [FieldOffset(352)] public NullablePointer @reward;
    [FieldOffset(360)] public bool @leaderDepartOnly;
    [FieldOffset(361)] public bool @soloMode;
}

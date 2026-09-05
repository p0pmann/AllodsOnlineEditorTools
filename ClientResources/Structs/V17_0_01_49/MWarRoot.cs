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

[StructSize(184)]
[XdbName("gameMechanics.world.gameRoot.MWarRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MWarRoot
{
    [FieldOffset(40)] public ResourcePointer @championRating;
    [FieldOffset(48)] public ResourcePointer @guildAuctionCurrency;
    [FieldOffset(56)] public ResourcePointer @guildRating;
    [FieldOffset(64)] public int @maxStakePlaceCorrection;
    [FieldOffset(68)] public int @minStake;
    [FieldOffset(72)] public float @minStakeStep;
    [FieldOffset(76)] public float @pillagePoolWinnerPart;
    [FieldOffset(80)] public float @pillageSafePart;
    [FieldOffset(84)] public float @pillagedPart;
    [FieldOffset(88)] public int @placeDeltaFactorCorrection;
    [FieldOffset(96, ArrayStride = 4)] public float[] @placeDeltaFactors;
    [FieldOffset(128)] public ResourcePointer @previousWeekGuildRating;
    [FieldOffset(136)] public int @rewardCount;
    [FieldOffset(144)] public ResourcePointer @rewardCurrency;
    [FieldOffset(152)] public float @rewardDecreaseFactor;
    [FieldOffset(156)] public Layouts.@s_122d150 @stakeBeatingAllowed;
}

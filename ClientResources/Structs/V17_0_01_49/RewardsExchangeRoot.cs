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

[StructSize(64)]
[XdbName("itemService.rewardsExchange.RewardsExchangeRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RewardsExchangeRoot
{
    [FieldOffset(36)] public int @maxBalanceRequest;
    [FieldOffset(40)] public int @maxBuyCount;
    [FieldOffset(44)] public float @maxSumandFactor;
    [FieldOffset(48)] public float @minSumandFactor;
    [FieldOffset(52)] public float @sumandFactorDiv1;
    [FieldOffset(56)] public float @sumandFactorDiv2;
}

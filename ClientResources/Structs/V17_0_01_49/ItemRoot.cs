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

[StructSize(264)]
[XdbName("gameMechanics.world.gameRoot.ItemRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemRoot
{
    [FieldOffset(36)] public float @baseGoldFactor;
    [FieldOffset(40)] public ResourcePointer @categoriesRegistry;
    [FieldOffset(48)] public ResourcePointer @copper;
    [FieldOffset(56)] public float @decayedItemsStackTimeDiff;
    [FieldOffset(64)] public NullablePointer @gearScoreCalcer;
    [FieldOffset(72)] public ResourcePointer @itemQualityCommon;
    [FieldOffset(80)] public ResourcePointer @itemQualityJunk;
    [FieldOffset(88)] public NullablePointer @itemmallCondition;
    [FieldOffset(96, ArrayStride = 16)] public Layouts.@s_15ab670[] @levelBudgetMods;
    [FieldOffset(128)] public int @maxAvatarAlternativeCurrency;
    [FieldOffset(136)] public long @maxAvatarMoney;
    [FieldOffset(144)] public ResourcePointer @metaItemCostRate;
    [FieldOffset(152, ArrayStride = 48)] public Layouts.@s_15ab5f0[] @metaItemUpgradeCritRates;
    [FieldOffset(184, ArrayStride = 48)] public Layouts.@s_15ab5f0[] @metaItemUpgradeRates;
    [FieldOffset(216, ArrayStride = 16)] public Layouts.@s_15ab670[] @metaLevelBudgetMods;
    [FieldOffset(248)] public float @powerGoldFactor;
    [FieldOffset(256)] public ResourcePointer @runeRegistry;
}

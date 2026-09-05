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

[StructSize(336)]
[XdbName("gameMechanics.world.gameRoot.ShipRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipRoot
{
    [FieldOffset(40)] public ResourcePointer @astrolabeSpell;
    [FieldOffset(48)] public ResourcePointer @chargedJumpSpell;
    [FieldOffset(56)] public Layouts.@s_15f5ba0 @defaultRunWave;
    [FieldOffset(88)] public Layouts.@s_15f59f0 @deviceIngredients;
    [FieldOffset(168)] public ResourcePointer @finishDevicesReplacementSpell;
    [FieldOffset(176)] public ResourcePointer @finishShipConstructionSpell;
    [FieldOffset(184)] public ResourcePointer @getShipProgressSpell;
    [FieldOffset(192)] public ResourcePointer @getShipRepairProgressSpell;
    [FieldOffset(200)] public float @repairTickPercent;
    [FieldOffset(204)] public float @repairTickResourceUsage;
    [FieldOffset(208)] public ResourcePointer @replaceDevicesSpell;
    [FieldOffset(216, ArrayStride = 72)] public Layouts.@s_15f5ce0[] @runWaveInfo;
    [FieldOffset(248)] public ResourcePointer @shipNameGeneratingInfo;
    [FieldOffset(256, ArrayStride = 48)] public Layouts.@s_15f5d60[] @shipUpgrades;
    [FieldOffset(288)] public ResourcePointer @showShipInProgressSpell;
    [FieldOffset(296)] public ResourcePointer @startRepairSpell;
    [FieldOffset(304)] public ResourcePointer @summonShipSpell;
    [FieldOffset(312)] public ResourcePointer @switchShipHullSpell;
    [FieldOffset(320)] public ResourcePointer @switchShipSkinSpell;
    [FieldOffset(328)] public ResourcePointer @unsummonShipSpell;
}

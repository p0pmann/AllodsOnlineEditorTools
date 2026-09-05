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

[StructSize(144)]
[XdbName("gameMechanics.constructor.schemes.item.ItemQuality")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemQuality
{
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @all;
    [FieldOffset(80)] public float @budgetMod;
    [FieldOffset(84)] public float @curePower;
    [FieldOffset(88)] public int @defaultReqLevelMod;
    [FieldOffset(92)] public float @defencePower;
    [FieldOffset(96)] public float @dpsPower;
    [FieldOffset(100)] public float @hpsPower;
    [FieldOffset(104)] public ResourcePointer @lootBagVisObject;
    [FieldOffset(112)] public float @powerMult;
    [FieldOffset(116)] public float @priceMod;
    [FieldOffset(120)] public float @primaryPower;
    [FieldOffset(124)][EnumRef(typeof(Enums.@e_10ab4a0))] public int @quality;
    [FieldOffset(128)] public float @secondaryMajorMod;
    [FieldOffset(132)] public float @secondaryMinorMod;
    [FieldOffset(136)] public float @wisdomMod;
}

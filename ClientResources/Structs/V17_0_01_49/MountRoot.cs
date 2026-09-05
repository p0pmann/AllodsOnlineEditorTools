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

[StructSize(232)]
[XdbName("gameMechanics.world.gameRoot.MountRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MountRoot
{
    [FieldOffset(40)] public ResourcePointer @contextActionGroup;
    [FieldOffset(48)] public ResourcePointer @damageThresholdResource;
    [FieldOffset(56)] public ResourcePointer @dismountGroup;
    [FieldOffset(64, ArrayStride = 8)] public ResourcePointer[] @excludeItemActionPreview;
    [FieldOffset(96)] public ResourcePointer @exoMountGroup;
    [FieldOffset(104)] public ResourcePointer @exoMountHealthModifier;
    [FieldOffset(112)] public NullablePointer @expPerDayCapCalcer;
    [FieldOffset(120)] public ResourcePointer @foodCurrency;
    [FieldOffset(128)] public float @hungryDiscountFactor;
    [FieldOffset(132)] public float @hungryPrepareDurationFactor;
    [FieldOffset(136)] public int @maxGrade;
    [FieldOffset(140)] public int @maxLevel;
    [FieldOffset(144)] public int @maxSatiationTime;
    [FieldOffset(152)] public Layouts.@s_1433350 @metamorphSwitchCost;
    [FieldOffset(176)] public ResourcePointer @mountHealthCalcer;
    [FieldOffset(184)] public float @mountMinHealth;
    [FieldOffset(192)] public ResourcePointer @mountedBuffsGroup;
    [FieldOffset(200)] public ResourcePointer @mountedSpellsGroup;
    [FieldOffset(208)] public int @singleFeedSatiationTime;
    [FieldOffset(216)] public ResourcePointer @slotCurrency;
    [FieldOffset(224)] public ResourcePointer @talentCurrency;
}

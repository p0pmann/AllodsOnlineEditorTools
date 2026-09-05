// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(169)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_15b8c40
{
    [FieldOffset(4)] public Layouts.@s_15b58e0 @agentProgression;
    [FieldOffset(16, ArrayStride = 24)] public Layouts.@s_15b57c0[] @chances;
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @enhancerPredicates;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @sourcePredicates;
    [FieldOffset(144)][EnumRef(typeof(Enums.@e_15b5990))] public int @upgradeChanceBehavior;
    [FieldOffset(148)] public float @upgradeCostMultiplier;
    [FieldOffset(152)] public ResourcePointer @upgradeCostMultiplierRate;
    [FieldOffset(160)] public NullablePointer @upgradeVector;
    [FieldOffset(168)] public bool @qualityDiffPenalty;
}

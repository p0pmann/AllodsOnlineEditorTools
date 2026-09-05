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

[StructSize(208)]
[XdbName("gameMechanics.world.gameRoot.StatsRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StatsRoot
{
    [FieldOffset(36)] public float @addedWillMod;
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @bonusStats;
    [FieldOffset(72)] public float @cureFactor;
    [FieldOffset(76)] public float @finisherEfficiency;
    [FieldOffset(80)] public NullablePointer @globalHealMod;
    [FieldOffset(88)] public float @lifestealMod;
    [FieldOffset(96)] public NullablePointer @mobHealthMod;
    [FieldOffset(104)] public float @plainEfficiency;
    [FieldOffset(108)] public float @rageEfficiency;
    [FieldOffset(112)] public Layouts.@s_1142770 @recommendedStats;
    [FieldOffset(152)] public NullablePointer @resistMod;
    [FieldOffset(160)] public int @statsLimitLevel;
    [FieldOffset(164)] public int @statsTurningLevel;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @uiVisibleStats;
    [FieldOffset(200)] public float @vitalityEfficiency;
}

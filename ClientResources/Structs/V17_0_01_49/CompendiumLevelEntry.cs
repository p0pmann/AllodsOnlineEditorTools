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

[SerializedExtent(176)]
[XdbName("itemService.compendium.CompendiumLevelEntry")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CompendiumLevelEntry
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_fc7b10[] @imageVariants;
    [FieldOffset(72)] public int @level;
    [FieldOffset(76)] public int @points;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @privateGoalRewards;
    [FieldOffset(112, ArrayStride = 8)] public ResourcePointer[] @rewards;
    [FieldOffset(144, ArrayStride = 8)] public ResourcePointer[] @rewardsVip;
}

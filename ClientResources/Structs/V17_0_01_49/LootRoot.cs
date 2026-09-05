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

[StructSize(128)]
[XdbName("gameMechanics.world.gameRoot.LootRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LootRoot
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @allLoot;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @allLootSchemes;
    [FieldOffset(104)] public int @greedNeedTimeCap;
    [FieldOffset(108)] public float @lootRange;
    [FieldOffset(112)] public float @resellPriceMultiplier;
    [FieldOffset(120)] public ResourcePointer @worldDrop;
}

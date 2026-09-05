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
[XdbName("gameMechanics.world.gameRoot.EnchantRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EnchantRoot
{
    [FieldOffset(40)] public NullablePointer @canHaveEnchants;
    [FieldOffset(48, ArrayStride = 56)] public Layouts.@s_103c590[] @enchantInsertRules;
    [FieldOffset(80, ArrayStride = 20)] public Layouts.@s_103c630[] @levelBudgets;
    [FieldOffset(112, ArrayStride = 20)] public Layouts.@s_103c6d0[] @statMods;
}

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
[XdbName("gameMechanics.world.gameRoot.SpellRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SpellRoot
{
    [FieldOffset(36)] public int @globalCooldown;
    [FieldOffset(40)] public Layouts.@s_1006790 @goldenSlotsRoot;
    [FieldOffset(152)] public ResourcePointer @groupEnchantedArrow;
    [FieldOffset(160)] public ResourcePointer @groupFairySpells;
    [FieldOffset(168)] public ResourcePointer @groupTwoEnchantedArrows;
    [FieldOffset(176)] public ResourcePointer @hearthstoneSpell;
    [FieldOffset(184)] public ResourcePointer @hearthstoneSpellImpl;
    [FieldOffset(192)] public ResourcePointer @meleeSpell;
    [FieldOffset(200)] public int @minTalentSelectLevel;
    [FieldOffset(208)] public ResourcePointer @noSpell;
    [FieldOffset(216)] public ResourcePointer @rangeSpell;
    [FieldOffset(224)] public ResourcePointer @switchTalentBuild;
    [FieldOffset(232)] public Layouts.@s_122d150 @willImmunityBuffDuration;
    [FieldOffset(256)] public bool @noNeedInFront;
}

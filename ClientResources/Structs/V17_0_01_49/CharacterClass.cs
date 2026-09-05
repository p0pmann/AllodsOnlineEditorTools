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

[StructSize(248)]
[XdbName("gameMechanics.world.avatar.CharacterClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterClass
{
    [FieldOffset(40)] public TextFileRef @Name;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @characterForms;
    [FieldOffset(104)] public string @className;
    [FieldOffset(128)] public float @hitDice;
    [FieldOffset(136, ArrayStride = 24)] public Layouts.@s_154afd0[] @itemClasses;
    [FieldOffset(168)] public float @manaDice;
    [FieldOffset(172)][EnumRef(typeof(Enums.@e_15b2850))] public int @manaType;
    [FieldOffset(176, ArrayStride = 8)] public ResourcePointer[] @sharedAbilities;
    [FieldOffset(208, ArrayStride = 8)] public ResourcePointer[] @sharedSpells;
    [FieldOffset(240)] public ResourcePointer @talentsTable;
}

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
[XdbName("gameMechanics.world.mob.MobWorld")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MobWorld
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(76)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public NullablePointer @spawnLocation;
    [FieldOffset(120)] public bool @manualCorpulence;
    [FieldOffset(136)] public TextFileRef @description;
    [FieldOffset(168)] public NullablePointer @interactions;
    [FieldOffset(176)] public ResourcePointer @kind;
    [FieldOffset(184)] public ResourcePointer @mobEventsScripts;
    [FieldOffset(192)] public ResourcePointer @modifier;
    [FieldOffset(200)][EnumRef(typeof(Enums.@e_15bc500))] public int @overtipCustomView;
    [FieldOffset(208)] public ResourcePointer @quality;
    [FieldOffset(216)] public TextFileRef @title;
    [FieldOffset(248)] public ResourcePointer @visMob;
    [FieldOffset(256)] public bool @canTalkWithEnemy;
    [FieldOffset(257)] public bool @hasBossPlate;
    [FieldOffset(258)] public bool @interestingCorpse;
    [FieldOffset(259)] public bool @removeFromUI;
    [FieldOffset(260)] public bool @usesWeapon;
}

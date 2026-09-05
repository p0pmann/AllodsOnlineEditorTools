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

[StructSize(304)]
[XdbName("gameMechanics.world.device.ChestResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ChestResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(76)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public NullablePointer @spawnLocation;
    [FieldOffset(120)] public bool @manualCorpulence;
    [FieldOffset(136)] public ResourcePointer @collision;
    [FieldOffset(144)] public float @customOcclusion;
    [FieldOffset(152)] public TextFileRef @exploitingText;
    [FieldOffset(184)] public NullablePointer @interactions;
    [FieldOffset(192)] public TextFileRef @openingText;
    [FieldOffset(224)] public float @scale;
    [FieldOffset(232)] public ResourcePointer @spell;
    [FieldOffset(240)] public TextFileRef @title;
    [FieldOffset(272)] public ResourcePointer @visObj;
    [FieldOffset(280)] public ResourcePointer @visScripts;
    [FieldOffset(288)] public bool @collisionObject;
    [FieldOffset(289)] public bool @interactiveObject;
    [FieldOffset(290)] public bool @isQuestOnly;
}

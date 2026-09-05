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
[XdbName("gameMechanics.world.avatar.CharacterRaceClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterRaceClass
{
    [FieldOffset(40)] public ResourcePointer @characterClass;
    [FieldOffset(48)] public ResourcePointer @characterRace;
    [FieldOffset(56)] public TextFileRef @description;
    [FieldOffset(88)] public TextFileRef @greatName;
    [FieldOffset(120)] public TextFileRef @name;
    [FieldOffset(152, ArrayStride = 24)] public Layouts.@s_154fba0[] @specialItemClasses;
    [FieldOffset(184)] public string @sysName;
}

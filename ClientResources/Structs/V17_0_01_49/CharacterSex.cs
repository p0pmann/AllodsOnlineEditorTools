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

[StructSize(80)]
[XdbName("gameMechanics.world.avatar.CharacterSex")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterSex
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_15f0df0))] public int @sex;
}

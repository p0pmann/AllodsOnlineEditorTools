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

[StructSize(288)]
[XdbName("gameMechanics.world.social.guild.base.GuildAbilityResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildAbilityResource
{
    [FieldOffset(48, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public string @groupName;
    [FieldOffset(136)] public int @groupQuality;
    [FieldOffset(144)] public ResourcePointer @image;
    [FieldOffset(152)] public TextFileRef @name;
    [FieldOffset(184, ArrayStride = 8)] public ResourcePointer[] @ranks;
    [FieldOffset(216)] public TextFileRef @shortDescription;
    [FieldOffset(248, ArrayStride = 8)] public ResourcePointer[] @spells;
    [FieldOffset(280)] public bool @useGuildBunchForCalcer;
}

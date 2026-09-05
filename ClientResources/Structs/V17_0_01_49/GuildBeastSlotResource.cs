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
[XdbName("gameMechanics.world.social.guild.clanhall.GuildBeastSlotResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildBeastSlotResource
{
    [FieldOffset(40)] public TextFileRef @customName;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_1008ab0))] public int @slot;
}

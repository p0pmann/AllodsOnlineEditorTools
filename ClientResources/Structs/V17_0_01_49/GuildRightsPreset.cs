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

[StructSize(72)]
[XdbName("gameMechanics.world.social.guild.base.GuildRightsPreset")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildRightsPreset
{
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_1581860))] public int[] @predifinedRights;
}

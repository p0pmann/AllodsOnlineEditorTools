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

[StructSize(688)]
[XdbName("gameMechanics.world.social.guild.base.GuildRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildRoot
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @banners;
    [FieldOffset(72)] public ResourcePointer @championTabard;
    [FieldOffset(80)] public Layouts.@s_fc0820 @clanHallRoot;
    [FieldOffset(408)] public ResourcePointer @forgetPoint;
    [FieldOffset(416)] public Layouts.@s_100e060 @guildBossRoot;
    [FieldOffset(472)] public int @guildDescriptionLimit;
    [FieldOffset(480, ArrayStride = 32)] public Layouts.@s_158a760[] @guildLevels;
    [FieldOffset(512)] public int @guildMemberDescrptionLimit;
    [FieldOffset(516)] public int @guildMembersLimit;
    [FieldOffset(520)] public int @guildMessageLimit;
    [FieldOffset(528, ArrayStride = 8)] public ResourcePointer[] @guildOnlyItems;
    [FieldOffset(560)] public ResourcePointer @guildPreset;
    [FieldOffset(568)] public ResourcePointer @guildProgressRewards;
    [FieldOffset(576, ArrayStride = 8)] public ResourcePointer[] @guildTalents;
    [FieldOffset(608)] public int @maxAvatarToFinishGuildQuest;
    [FieldOffset(612)] public int @maxGuildLevel;
    [FieldOffset(616)] public int @maxGuildLoyalty;
    [FieldOffset(620)] public int @minGuildLoyalty;
    [FieldOffset(624, ArrayStride = 8)] public ResourcePointer[] @profitable;
    [FieldOffset(656)] public ResourcePointer @switchTactics;
    [FieldOffset(664)] public ResourcePointer @tabard;
    [FieldOffset(672)] public long @tabardDistributionDelay;
    [FieldOffset(680)] public ResourcePointer @talentPoint;
}

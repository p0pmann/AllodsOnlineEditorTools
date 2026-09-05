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

[StructSize(88)]
[XdbName("gameMechanics.world.social.guild.bank.GuildBankRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildBankRoot
{
    [FieldOffset(36)] public int @guildHistoryPageSize;
    [FieldOffset(40)] public int @itemHistoryPageSize;
    [FieldOffset(48)] public long @maximumGuildMoney;
    [FieldOffset(56)] public long @maximumTransaction;
    [FieldOffset(64)] public int @memberHistorySize;
    [FieldOffset(72)] public long @minimumTransaction;
    [FieldOffset(80)] public int @moneyHistorySize;
    [FieldOffset(84)] public int @operationHistorySize;
}

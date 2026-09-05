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

[StructSize(96)]
[XdbName("gameMechanics.world.social.guild.boss.GuildBossState")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildBossState
{
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_100ae70))] public int[] @availableAbilitySlots;
    [FieldOffset(72)] public long @experienceLimit;
    [FieldOffset(80)] public ResourcePointer @mobWorld;
    [FieldOffset(88)] public bool @showInPreview;
}

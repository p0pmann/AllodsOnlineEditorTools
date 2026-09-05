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

[StructSize(152)]
[XdbName("gameMechanics.world.social.guild.boss.GuildBossResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildBossResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @activeSpell;
    [FieldOffset(72)] public ResourcePointer @background;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @bossStates;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @passiveAbilities;
    [FieldOffset(144)] public ResourcePointer @preview;
}

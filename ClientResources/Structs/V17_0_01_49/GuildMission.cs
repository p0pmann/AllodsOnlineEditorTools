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
[XdbName("itemService.avatar.guild.GuildMission")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildMission
{
    [FieldOffset(40)] public TextFileRef @counter;
    [FieldOffset(72)] public ResourcePointer @currency;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_10110c0))] public int @guildMissionType;
    [FieldOffset(120)] public ResourcePointer @image;
    [FieldOffset(128)] public TextFileRef @name;
    [FieldOffset(160, ArrayStride = 8)] public ResourcePointer[] @requiredItems;
    [FieldOffset(192)] public NullablePointer @reward;
    [FieldOffset(200)] public int @softCap;
    [FieldOffset(204)] public bool @isAvailableOnP2P;
    [FieldOffset(205)] public bool @isHidden;
}

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

[StructSize(64)]
[XdbName("gameMechanics.world.social.guild.tabards.GuildBannerResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildBannerResource
{
    [FieldOffset(40)] public ResourcePointer @currency;
    [FieldOffset(48)] public ResourcePointer @previewItem;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_160e710))] public int @tabardType;
}

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
[XdbName("gameMechanics.world.social.guild.base.GuildTalentFieldResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildTalentFieldResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @image;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112, ArrayStride = 40)] public Layouts.@s_104eb80[] @rows;
    [FieldOffset(144)] public int @startColumn;
    [FieldOffset(148)] public int @startRow;
}

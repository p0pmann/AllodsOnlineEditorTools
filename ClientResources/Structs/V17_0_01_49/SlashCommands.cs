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

[StructSize(136)]
[XdbName("SlashCommands")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SlashCommands
{
    [FieldOffset(40, ArrayStride = 112)] public Layouts.@s_95af40[] @commands;
    [FieldOffset(72, ArrayStride = 192)] public Layouts.@s_95b0d0[] @emoteCommands;
    [FieldOffset(104)] public TextFileRef @slashPrefixes;
}

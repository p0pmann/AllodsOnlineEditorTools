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
[XdbName("GuildResourcesRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GuildResourcesRoot
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @canvas;
    [FieldOffset(72, ArrayStride = 40)] public Layouts.@s_1963060[] @emblems;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @guildTextures;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @guildVisObjects;
    [FieldOffset(168)] public Layouts.@s_1963060 @pattern;
}

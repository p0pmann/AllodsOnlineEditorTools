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

[StructSize(312)]
[XdbName("GameViewScene")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewScene
{
    [FieldOffset(40)] public Layouts.@s_17dc480 @cameraPlacement;
    [FieldOffset(96, ArrayStride = 72)] public Layouts.@s_17d98b0[] @devices;
    [FieldOffset(128, ArrayStride = 48)] public Layouts.@s_17d9cd0[] @guilds;
    [FieldOffset(160, ArrayStride = 192)] public Layouts.@s_17db320[] @mobs;
    [FieldOffset(192, ArrayStride = 72)] public Layouts.@s_17dbae0[] @paths;
    [FieldOffset(224)] public Layouts.@s_17dc7d0 @place;
    [FieldOffset(280, ArrayStride = 136)] public Layouts.@s_11c4f10[] @ships;
}

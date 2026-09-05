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

[StructSize(280)]
[XdbName("UICharacterScenes")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UICharacterScenes
{
    [FieldOffset(40, ArrayStride = 152)] public Layouts.@s_1bc9980[] @characterScenes;
    [FieldOffset(72)] public Layouts.@s_1bc7980 @missionCharacterScreenScene;
    [FieldOffset(256)] public Layouts.@s_1bc7a10 @preMissionCamera;
}

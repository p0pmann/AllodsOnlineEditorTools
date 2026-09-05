// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(147)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1bc9980
{
    [FieldOffset(4)] public float @cameraFOV;
    [FieldOffset(8)] public float @cameraHeight;
    [FieldOffset(12)] public Layouts.@s_1bcaba0 @cameraPlace;
    [FieldOffset(48)] public float @cameraZoomSpeedModifier;
    [FieldOffset(52)] public Layouts.@s_1bcaba0 @characterPlace;
    [FieldOffset(88)] public float @characterScale;
    [FieldOffset(96)] public string @mapName;
    [FieldOffset(120)] public string @name;
    [FieldOffset(144)] public bool @chargenMode;
    [FieldOffset(145)] public bool @isSceneBackgroundVideo;
    [FieldOffset(146)] public bool @useCameraZoomController;
}

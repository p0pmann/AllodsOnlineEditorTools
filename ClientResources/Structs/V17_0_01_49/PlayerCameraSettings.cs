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

[StructSize(128)]
[XdbName("PlayerCameraSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PlayerCameraSettings
{
    [FieldOffset(36)] public Layouts.@s_1b00fb0 @autoreturn;
    [FieldOffset(56)] public float @fovStep;
    [FieldOffset(60)] public float @maxTransparencyDistance;
    [FieldOffset(64)] public float @maxZoomDistance;
    [FieldOffset(68)] public float @maxZoomStep;
    [FieldOffset(72)] public float @minTransparencyDistance;
    [FieldOffset(76)] public float @minZoomDistance;
    [FieldOffset(80)] public float @minZoomStep;
    [FieldOffset(84)] public float @zoomStep;
    [FieldOffset(88, ArrayStride = 12)] public Layouts.@s_1b01050[] @zoomSteps;
    [FieldOffset(120)] public bool @headBob;
    [FieldOffset(121)] public bool @smartAutoreturn;
}

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

[StructSize(72)]
[XdbName("ObjectCameraSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ObjectCameraSettings
{
    [FieldOffset(36)] public float @maxPitch;
    [FieldOffset(40)] public float @maxYaw;
    [FieldOffset(44)] public float @maxZoomDistance;
    [FieldOffset(48)] public float @minPitch;
    [FieldOffset(52)] public float @minZoomDistance;
    [FieldOffset(56)] public float @zoomSpeed;
    [FieldOffset(60)] public float @zoomStep;
    [FieldOffset(64)] public bool @checkCollisions;
}

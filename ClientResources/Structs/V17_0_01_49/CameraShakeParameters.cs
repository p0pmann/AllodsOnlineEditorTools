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
[XdbName("CameraShakeParameters")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CameraShakeParameters
{
    [FieldOffset(36)] public float @amplitudeScale;
    [FieldOffset(40)] public ResourcePointer @animation;
    [FieldOffset(48)] public float @maxRadius;
    [FieldOffset(52)] public float @minRadius;
    [FieldOffset(56)] public float @timeScale;
    [FieldOffset(60)] public bool @looped;
}

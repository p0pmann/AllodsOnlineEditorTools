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

[SerializedExtent(160)]
[XdbName("CameraTrackAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CameraTrackAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 20)] public Layouts.@s_18e05a0[] @cameraPoints;
    [FieldOffset(104)] public ResourcePointer @cameraRoute;
    [FieldOffset(112)] public float @routeDuration;
    [FieldOffset(120, ArrayStride = 20)] public Layouts.@s_18e05a0[] @targetPoints;
    [FieldOffset(152)] public ResourcePointer @targetRoute;
}

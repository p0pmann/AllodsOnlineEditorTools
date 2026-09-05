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

[SerializedExtent(40)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cbbbf0
{
    [FieldOffset(4)] public Vector3 @cameraAnchor;
    [FieldOffset(16)] public float @cameraBodyAnchorCoeff;
    [FieldOffset(20)] public float @preMissionAdditionalAway;
    [FieldOffset(24)] public Vector3 @preMissionFaceCameraAnchor;
    [FieldOffset(36)] public float @scale;
}

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

[SerializedExtent(138)]
[XdbName("AlignCollisionComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AlignCollisionComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public float @endHeight;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96)] public Vector3 @offset;
    [FieldOffset(108)] public float @scale;
    [FieldOffset(112)] public float @sphereRadius;
    [FieldOffset(116)] public float @startHeight;
    [FieldOffset(120)] public ResourcePointer @visObject;
    [FieldOffset(128)] public float @yaw;
    [FieldOffset(132)] public bool @alignNormal;
    [FieldOffset(133)] public bool @checkNormal;
    [FieldOffset(134)] public bool @fixedPosition;
    [FieldOffset(135)] public bool @getPrevObjectHeight;
    [FieldOffset(136)] public bool @lockScale;
    [FieldOffset(137)] public bool @placeAlways;
}

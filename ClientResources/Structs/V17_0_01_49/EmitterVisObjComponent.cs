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

[SerializedExtent(185)]
[XdbName("EmitterVisObjComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EmitterVisObjComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public int @delay;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96)] public Vector3 @maxAngles;
    [FieldOffset(108)] public float @maxScale;
    [FieldOffset(112)] public Vector3 @minAngles;
    [FieldOffset(124)] public float @minScale;
    [FieldOffset(128)] public Vector3 @offset;
    [FieldOffset(140)] public float @radius;
    [FieldOffset(144)] public float @rate;
    [FieldOffset(152, ArrayStride = 8)] public ResourcePointer[] @visObjects;
    [FieldOffset(184)] public bool @fixedPoint;
}

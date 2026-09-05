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

[SerializedExtent(122)]
[XdbName("CreatureIndependentFxAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureIndependentFxAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)] public float @delay;
    [FieldOffset(72)] public float @lifeTime;
    [FieldOffset(76)] public Vector3 @offset;
    [FieldOffset(88)] public Vector3 @rotation;
    [FieldOffset(100)] public float @scale;
    [FieldOffset(104)] public int @visEventPointIndex;
    [FieldOffset(112)] public ResourcePointer @visObject;
    [FieldOffset(120)] public bool @isRelative;
    [FieldOffset(121)] public bool @useCastPoint;
}

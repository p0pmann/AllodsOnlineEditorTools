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

[SerializedExtent(137)]
[XdbName("ParticleTrailComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ParticleTrailComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96)] public Vector3 @offset;
    [FieldOffset(112)] public ResourcePointer @particleTrailResource;
    [FieldOffset(120)] public Vector3 @rotation;
    [FieldOffset(132)] public float @scale;
    [FieldOffset(136)] public bool @destroyAtAnimationEnd;
}

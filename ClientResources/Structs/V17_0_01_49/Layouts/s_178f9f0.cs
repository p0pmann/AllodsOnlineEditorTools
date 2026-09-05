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

[SerializedExtent(66)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_178f9f0
{
    [FieldOffset(4)] public int @delay;
    [FieldOffset(8)] public ResourcePointer @effectFx;
    [FieldOffset(16)] public int @fadeInTime;
    [FieldOffset(20)] public int @fadeOutTime;
    [FieldOffset(24)] public string @locatorName;
    [FieldOffset(48)] public Vector3 @offset;
    [FieldOffset(60)] public float @scale;
    [FieldOffset(64)] public bool @fixPoint;
    [FieldOffset(65)] public bool @lockScale;
}

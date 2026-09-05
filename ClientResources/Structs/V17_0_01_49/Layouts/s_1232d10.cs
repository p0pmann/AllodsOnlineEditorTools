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

[SerializedExtent(70)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1232d10
{
    [FieldOffset(8)] public ResourcePointer @camera;
    [FieldOffset(16)] public float @distance;
    [FieldOffset(20)] public float @fogEnd;
    [FieldOffset(24)] public float @fogStart;
    [FieldOffset(28)] public float @fov;
    [FieldOffset(32)] public Vector3 @position;
    [FieldOffset(44)] public Quaternion @rotation;
    [FieldOffset(60)] public float @softFaderEnd;
    [FieldOffset(64)] public float @softFaderStart;
    [FieldOffset(68)] public bool @hasCrosshair;
    [FieldOffset(69)] public bool @isBinding;
}

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

[SerializedExtent(97)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c54560
{
    [FieldOffset(8, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @disablePhysicsAnimations;
    [FieldOffset(40)] public Vector3 @gravity;
    [FieldOffset(52)] public float @mass;
    [FieldOffset(56, ArrayStride = 24)] public string[] @nodes;
    [FieldOffset(88)] public float @resistance;
    [FieldOffset(92)] public float @spring;
    [FieldOffset(96)] public bool @useDefaultGravity;
}

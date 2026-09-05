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

[SerializedExtent(80)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_190acf0
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_168610))] public int @idleAnimation;
    [FieldOffset(8)] public ResourcePointer @item;
    [FieldOffset(16)] public ResourcePointer @object;
    [FieldOffset(24)] public Vector3 @position;
    [FieldOffset(36)] public int @rotate;
    [FieldOffset(40)] public float @scale;
    [FieldOffset(48, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @winAnimations;
}

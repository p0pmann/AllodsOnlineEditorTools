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

[SerializedExtent(120)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c78350
{
    [FieldOffset(8)] public string @archiAnimationSlotName;
    [FieldOffset(32)] public string @mountSlotName;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_c5d710))] public int @name;
    [FieldOffset(60)] public Vector2 @positionIdle;
    [FieldOffset(68)] public Vector2 @positionMelee;
    [FieldOffset(76)] public Vector2 @positionRanged;
    [FieldOffset(88, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @slots;
}

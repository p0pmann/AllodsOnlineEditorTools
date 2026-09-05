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

[SerializedExtent(64)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1967e40
{
    [FieldOffset(8, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @afterDeathAnimations;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_168610))] public int @gotoDeathRealmAnimation;
    [FieldOffset(44)] public int @sparkMovingMaxTime;
    [FieldOffset(48)] public float @sparkMovingSpeed;
    [FieldOffset(56)] public ResourcePointer @sparkVisObjectAlias;
}

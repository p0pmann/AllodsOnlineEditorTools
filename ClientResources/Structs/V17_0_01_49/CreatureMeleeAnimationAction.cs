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

[SerializedExtent(198)]
[XdbName("CreatureMeleeAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureMeleeAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 8)] public NullablePointer[] @animationKeysAction;
    [FieldOffset(104, ArrayStride = 8)] public NullablePointer[] @animationKeysActionPeriod;
    [FieldOffset(136, ArrayStride = 8)] public NullablePointer[] @animationKeysSound;
    [FieldOffset(168)][EnumRef(typeof(Enums.@e_168610))] public int @castAnimation;
    [FieldOffset(172)][EnumRef(typeof(Enums.@e_1733130))] public int @channel;
    [FieldOffset(176)][EnumRef(typeof(Enums.@e_168610))] public int @preCastAnimation;
    [FieldOffset(180)] public float @speed;
    [FieldOffset(184)][EnumRef(typeof(Enums.@e_18f1f10))] public int @useCast;
    [FieldOffset(188)][EnumRef(typeof(Enums.@e_18f1f10))] public int @usePreCast;
    [FieldOffset(192)] public bool @backgroundAfterFirstKey;
    [FieldOffset(193)] public bool @stopIfMoved;
    [FieldOffset(194)] public bool @stopIfOverrided;
    [FieldOffset(195)] public bool @stopIfRotated;
    [FieldOffset(196)] public bool @turnToTargetOnCast;
    [FieldOffset(197)] public bool @turnToTargetOnPreCast;
}

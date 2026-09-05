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

[SerializedExtent(150)]
[XdbName("CreatureThrowArrowAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureThrowArrowAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public ResourcePointer @additionalEffectFx;
    [FieldOffset(80)] public ResourcePointer @arrow;
    [FieldOffset(88)] public int @arrowInTargetTime;
    [FieldOffset(96)] public string @effectBone;
    [FieldOffset(120)] public int @enchantedArrowIndex;
    [FieldOffset(124)] public int @fixedThrowDuration;
    [FieldOffset(128)] public NullablePointer @offendTime;
    [FieldOffset(136)] public float @pointInTargetMax;
    [FieldOffset(140)] public float @pointInTargetMin;
    [FieldOffset(144)] public float @theGe;
    [FieldOffset(148)] public bool @useMeleeWeapon;
    [FieldOffset(149)] public bool @usePointInArrow;
}

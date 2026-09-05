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

[SerializedExtent(137)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cabf10
{
    [FieldOffset(8, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @addedToUseAnimations;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_caa6e0))] public int @horizontalRotate;
    [FieldOffset(44)] public float @maxHeadAngleToDown;
    [FieldOffset(48)] public float @maxHeadAngleToSide;
    [FieldOffset(52)] public float @maxHeadAngleToUp;
    [FieldOffset(56)] public string @targetBoneName;
    [FieldOffset(80)] public float @trackingTimeOut;
    [FieldOffset(88)] public Layouts.@s_a96d80 @turnSound;
    [FieldOffset(128)][EnumRef(typeof(Enums.@e_caa6e0))] public int @verticalRotate;
    [FieldOffset(132)] public bool @ingnoreRotateToTarget;
    [FieldOffset(133)] public bool @noRotateBody;
    [FieldOffset(134)] public bool @use;
    [FieldOffset(135)] public bool @useInEveryAnimation;
    [FieldOffset(136)] public bool @useOnlyAddedAnimations;
}

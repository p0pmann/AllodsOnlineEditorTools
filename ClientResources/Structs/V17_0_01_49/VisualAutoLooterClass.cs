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

[StructSize(160)]
[XdbName("VisualAutoLooterClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualAutoLooterClass
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_168610))] public int @animateHide;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_168610))] public int @animateIdle;
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_168610))] public int @animateLoot;
    [FieldOffset(48)][EnumRef(typeof(Enums.@e_168610))] public int @animateRun;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_168610))] public int @animateShow;
    [FieldOffset(56)] public Vector3 @avatarOffset;
    [FieldOffset(68)] public float @fadeInTime;
    [FieldOffset(72)] public float @fadeOutTime;
    [FieldOffset(76)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(80)] public string @locatorName;
    [FieldOffset(104)] public Vector3 @lootOffset;
    [FieldOffset(116)] public float @maxRoll;
    [FieldOffset(120)] public float @maxRollSpeed;
    [FieldOffset(124)] public float @maxTurnSpeed;
    [FieldOffset(128)] public float @minHeight;
    [FieldOffset(132)] public float @rollRotationCoef;
    [FieldOffset(136)] public float @rotationDistPart;
    [FieldOffset(140)] public float @scale;
    [FieldOffset(144)] public float @turnSpeeddownCoef;
    [FieldOffset(148)] public float @turnSpeeddownLim;
    [FieldOffset(152)] public float @turnSpeedownMinAngle;
}

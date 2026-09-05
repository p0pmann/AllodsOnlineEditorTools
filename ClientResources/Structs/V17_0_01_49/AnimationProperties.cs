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

[StructSize(304)]
[XdbName("AnimationProperties")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AnimationProperties
{
    [FieldOffset(40)] public string @headBoneName;
    [FieldOffset(64)] public float @headTurnTime;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_caa970))] public int @kind;
    [FieldOffset(72)] public float @legAlignTime;
    [FieldOffset(76)] public float @legRunTurnTime;
    [FieldOffset(80)] public float @maxHeadAngle;
    [FieldOffset(84)] public float @run;
    [FieldOffset(88)] public Layouts.@s_caa5f0 @specialShuffleParams;
    [FieldOffset(104)] public string @spineBoneName;
    [FieldOffset(128)] public float @swimHeight;
    [FieldOffset(136)] public Layouts.@s_cabf10 @targetTrackingParams;
    [FieldOffset(280)] public float @turnSpeedModifier;
    [FieldOffset(284)] public float @walk;
    [FieldOffset(288)] public float @walkBackwards;
    [FieldOffset(292)] public float @walkForward;
    [FieldOffset(296)] public bool @canWalkBackwards;
    [FieldOffset(297)] public bool @finishMoveAnimation;
    [FieldOffset(298)] public bool @forceMoveDisableUsed;
    [FieldOffset(299)] public bool @groundNormalByBoundingBox;
    [FieldOffset(300)] public bool @moveAnimationsNoScale;
    [FieldOffset(301)] public bool @useWalkForward;
}

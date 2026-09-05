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

[StructSize(640)]
[XdbName("MobAnimations")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MobAnimations
{
    [FieldOffset(40)] public Layouts.@s_c506c0 @attack;
    [FieldOffset(88)] public Layouts.@s_c506c0 @attackSwim;
    [FieldOffset(136)] public Layouts.@s_c506c0 @death;
    [FieldOffset(184)] public Layouts.@s_c506c0 @idle;
    [FieldOffset(232)] public int @idlePeriodMax;
    [FieldOffset(236)] public int @idlePeriodMin;
    [FieldOffset(240)] public Layouts.@s_c506c0 @idleSwim;
    [FieldOffset(288)] public int @idleSwimPeriodMax;
    [FieldOffset(292)] public int @idleSwimPeriodMin;
    [FieldOffset(296, ArrayStride = 16)] public Layouts.@s_c65670[] @meleeAttackScripts;
    [FieldOffset(328, ArrayStride = 16)] public Layouts.@s_c65670[] @rangedAttackScripts;
    [FieldOffset(360)] public Layouts.@s_c506c0 @run;
    [FieldOffset(408)] public Layouts.@s_c506c0 @runInstantAnimations;
    [FieldOffset(456)] public int @runInstantPeriodMax;
    [FieldOffset(460)] public int @runInstantPeriodMin;
    [FieldOffset(464)] public Layouts.@s_c66500 @specialIdleParams;
    [FieldOffset(488)] public Layouts.@s_c506c0 @swim;
    [FieldOffset(536)] public Layouts.@s_c506c0 @walk;
    [FieldOffset(584)] public Layouts.@s_c506c0 @walkInstantAnimations;
    [FieldOffset(632)] public int @walkInstantPeriodMax;
    [FieldOffset(636)] public int @walkInstantPeriodMin;
}

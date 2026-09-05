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

[StructSize(144)]
[XdbName("MobEventsScripts")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MobEventsScripts
{
    [FieldOffset(40)] public NullablePointer @aggroScript;
    [FieldOffset(48)] public Layouts.@s_c5c550 @deathScriptParams;
    [FieldOffset(80)] public Layouts.@s_c62460 @enemyHealth;
    [FieldOffset(96)] public Layouts.@s_c5e0f0 @idleScriptParams;
    [FieldOffset(120)] public Layouts.@s_c62460 @mobHealth;
    [FieldOffset(136)] public NullablePointer @preAggroScript;
}

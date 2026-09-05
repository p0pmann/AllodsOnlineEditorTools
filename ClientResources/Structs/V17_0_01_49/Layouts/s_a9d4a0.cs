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

[SerializedExtent(81)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_a9d4a0
{
    [FieldOffset(4)] public float @brightness;
    [FieldOffset(8)] public int @color;
    [FieldOffset(12)] public int @colorUp;
    [FieldOffset(16)] public float @densityDown;
    [FieldOffset(20)] public float @densityUp;
    [FieldOffset(24)] public Layouts.@s_a9c3b0 @distanceSettings;
    [FieldOffset(40)] public Layouts.@s_a9c430 @heightSettingsDown;
    [FieldOffset(56)] public Layouts.@s_a9c430 @heightSettingsUp;
    [FieldOffset(72)] public Layouts.@s_a9c4b0 @sunSettings;
    [FieldOffset(80)] public bool @use;
}

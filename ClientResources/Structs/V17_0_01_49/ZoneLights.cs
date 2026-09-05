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

[StructSize(440)]
[XdbName("ZoneLights")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ZoneLights
{
    [FieldOffset(36)] public Layouts.@s_aaa190 @bloomSettings;
    [FieldOffset(56)] public Layouts.@s_a9c330 @colorGradingSettings;
    [FieldOffset(72)] public Layouts.@s_aaa440 @defaultLight;
    [FieldOffset(352)] public int @index;
    [FieldOffset(360, ArrayStride = 280)] public Layouts.@s_aaa440[] @instantLights;
    [FieldOffset(392, ArrayStride = 328)] public Layouts.@s_aaa6d0[] @randomLights;
    [FieldOffset(424)] public ResourcePointer @waterLight;
    [FieldOffset(432)] public float @waterReflectionCoefficient;
    [FieldOffset(436)] public bool @fogUsesQualitySettings;
    [FieldOffset(437)] public bool @hiQualitySky;
    [FieldOffset(438)] public bool @renderSky;
}

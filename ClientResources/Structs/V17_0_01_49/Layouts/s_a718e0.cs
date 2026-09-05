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

[SerializedExtent(136)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_a718e0
{
    [FieldOffset(4)] public int @AmbientColor;
    [FieldOffset(8)] public float @AmbientFactor;
    [FieldOffset(12)] public int @ContourColor;
    [FieldOffset(16)] public int @DiffuseColor;
    [FieldOffset(20)] public float @FadeEnd;
    [FieldOffset(24)] public float @FadeStart;
    [FieldOffset(28)] public int @FogColor;
    [FieldOffset(32)] public float @FogEnd;
    [FieldOffset(36)] public float @FogStart;
    [FieldOffset(40)] public int @GrassContourColorMultiplier;
    [FieldOffset(44)] public int @PointLightColor;
    [FieldOffset(48)] public int @SelfIllumColor;
    [FieldOffset(52)] public int @SpecularColor;
    [FieldOffset(56)] public int @SpecularWaterColor;
    [FieldOffset(60)] public float @SunLightPitch;
    [FieldOffset(64)] public float @SunLightYaw;
    [FieldOffset(68)] public int @TerrainContourColor;
    [FieldOffset(72)] public float @TerrainContourPower;
    [FieldOffset(76)] public int @TerrainSpecularColor;
    [FieldOffset(80)] public int @WaterGradientEnd;
    [FieldOffset(84)] public int @WaterGradientStart;
    [FieldOffset(88)] public ResourcePointer @animatedAmbientColor;
    [FieldOffset(96)] public ResourcePointer @animatedDiffuseColor;
    [FieldOffset(104)] public ResourcePointer @animatedPointLightColor;
    [FieldOffset(112)] public ResourcePointer @animatedSelfIllumColor;
    [FieldOffset(120)] public float @desaturation;
    [FieldOffset(124)] public int @minAmbientOcclusionValue;
    [FieldOffset(128)] public float @objectsLightmapBias;
    [FieldOffset(132)] public float @terrainLightmapBias;
}

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

[SerializedExtent(129)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c13f30
{
    [FieldOffset(8)] public string @SymbolName;
    [FieldOffset(32)] public ResourcePointer @bumpTexture;
    [FieldOffset(40)] public ResourcePointer @fresnelDown;
    [FieldOffset(48)] public ResourcePointer @fresnelUp;
    [FieldOffset(56)] public ResourcePointer @fresnelUpWaterWaves;
    [FieldOffset(64)] public float @simpleWaterOpacity;
    [FieldOffset(68)] public int @waterAdditionalColor;
    [FieldOffset(72)] public float @waterAlpha;
    [FieldOffset(76)] public float @waterReflectionContribution;
    [FieldOffset(80)] public float @waterSpecularCoeff;
    [FieldOffset(84)] public int @waterSpeedMultiply;
    [FieldOffset(88)] public ResourcePointer @wave;
    [FieldOffset(96)] public int @waveAdditionalColor;
    [FieldOffset(104)] public ResourcePointer @waveBump;
    [FieldOffset(112)] public float @waveHeight;
    [FieldOffset(116)] public float @waveReflectionContribution;
    [FieldOffset(120)] public int @waveSpeedMultiply;
    [FieldOffset(124)] public float @waveWidth;
    [FieldOffset(128)] public bool @waveUseWaterSettings;
}

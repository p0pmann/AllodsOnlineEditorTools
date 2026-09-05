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

[StructSize(288)]
[XdbName("AstralShadingParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralShadingParams
{
    [FieldOffset(36)] public int @AmbientColor;
    [FieldOffset(40)] public int @ContourColor;
    [FieldOffset(44)] public int @DiffuseColor;
    [FieldOffset(48)] public int @ForceFieldGradientColor;
    [FieldOffset(52)] public int @ForceFieldInnerColor;
    [FieldOffset(56)] public int @ForceFieldOuterColor;
    [FieldOffset(60)] public int @HaloColor;
    [FieldOffset(64)] public float @HaloEnd;
    [FieldOffset(68)] public float @HaloIntensity;
    [FieldOffset(72)] public float @HaloStart;
    [FieldOffset(76)] public float @astralDropLifeTime;
    [FieldOffset(80)] public float @astralDropSize;
    [FieldOffset(84)] public float @astralDropSpeed;
    [FieldOffset(88)] public ResourcePointer @astralObject;
    [FieldOffset(96)] public int @effectColor;
    [FieldOffset(100)] public int @gridMultiply;
    [FieldOffset(104)] public float @maxTubeDIstance;
    [FieldOffset(108)] public float @nodeShift;
    [FieldOffset(112)] public float @randomNodeProbability;
    [FieldOffset(120, ArrayStride = 24)] public Layouts.@s_cd40c0[] @randomNodes;
    [FieldOffset(152)] public float @randomTubeProbability;
    [FieldOffset(160, ArrayStride = 24)] public Layouts.@s_cd41d0[] @randomTubes;
    [FieldOffset(192)] public float @shiftFreq;
    [FieldOffset(196)] public float @thunderEffectWidth;
    [FieldOffset(200, ArrayStride = 8)] public ResourcePointer[] @thunderEffects;
    [FieldOffset(232)] public int @tubeColor;
    [FieldOffset(236)] public float @tubeEffectWidth;
    [FieldOffset(240, ArrayStride = 8)] public ResourcePointer[] @tubeEffects;
    [FieldOffset(272)] public float @tubeFrequency;
    [FieldOffset(276)] public float @tubeShift;
    [FieldOffset(280)] public float @tubeWidth;
    [FieldOffset(284)] public bool @disableAstralSpheres;
}

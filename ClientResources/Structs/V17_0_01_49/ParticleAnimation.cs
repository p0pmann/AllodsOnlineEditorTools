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

[StructSize(352)]
[XdbName("ParticleAnimation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ParticleAnimation
{
    [FieldOffset(40, ArrayStride = 88)] public Layouts.@s_187200[] @ParticleEmitters;
    [FieldOffset(72)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(96)] public Layouts.@s_2106e0 @animation;
    [FieldOffset(112)] public FileRef @binaryFile;
    [FieldOffset(152)] public Layouts.@s_182c30 @decal;
    [FieldOffset(192)] public int @endFrame;
    [FieldOffset(196)] public Layouts.@s_182ea0 @fade;
    [FieldOffset(212)] public int @loopFrame;
    [FieldOffset(216)] public float @scaleDistanceEnd;
    [FieldOffset(220)] public float @scaleDistanceStart;
    [FieldOffset(224, ArrayStride = 8)] public ResourcePointer[] @singleTextures;
    [FieldOffset(256)] public float @speed;
    [FieldOffset(264)] public ResourcePointer @texture;
    [FieldOffset(272)] public Layouts.@s_17f0c0 @textureAtlasParameters;
    [FieldOffset(312, ArrayStride = 8)] public ResourcePointer[] @textures;
    [FieldOffset(344)] public bool @looped;
}

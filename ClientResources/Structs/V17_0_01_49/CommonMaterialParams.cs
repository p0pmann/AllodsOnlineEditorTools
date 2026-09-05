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

[SerializedExtent(126)]
[XdbName("CommonMaterialParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CommonMaterialParams
{
    [FieldOffset(48)] public ResourcePointer @bumpTexture;
    [FieldOffset(56)] public int @color;
    [FieldOffset(60)] public int @contourColorModifier;
    [FieldOffset(64)] public ResourcePointer @effectMaskTexture;
    [FieldOffset(72)] public ResourcePointer @envReflectionTexture;
    [FieldOffset(80)] public ResourcePointer @envSpecularTexture;
    [FieldOffset(88)] public float @shininess;
    [FieldOffset(92)] public int @specularColorModifier;
    [FieldOffset(96)] public float @specularIntensity;
    [FieldOffset(100)] public Layouts.@s_ad0100 @transparencyModifier;
    [FieldOffset(120)] public bool @bumpDisabled;
    [FieldOffset(121)] public bool @selfillum;
    [FieldOffset(122)] public bool @useEnvContourColorFactor;
    [FieldOffset(123)] public bool @useEnvSpecularColorFactor;
    [FieldOffset(124)] public bool @useMaskColor;
    [FieldOffset(125)] public bool @vertexBakedLight;
}

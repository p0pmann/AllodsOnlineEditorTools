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

[SerializedExtent(369)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c13ae0
{
    [FieldOffset(8)] public ResourcePointer @DiffuseTexture;
    [FieldOffset(16)] public float @DirectionalExponent;
    [FieldOffset(20)] public int @DirectionalSpeculatLightColor;
    [FieldOffset(24)] public float @EyeExponent;
    [FieldOffset(28)] public int @EyeSpecularLightColor;
    [FieldOffset(32)] public int @LayerColor;
    [FieldOffset(40)] public string @SymbolName;
    [FieldOffset(64)] public Layouts.@s_c105f0 @foliage0;
    [FieldOffset(136)] public Layouts.@s_c105f0 @foliage1;
    [FieldOffset(208)] public Layouts.@s_c105f0 @foliage2;
    [FieldOffset(280)] public Layouts.@s_c105f0 @foliage3;
    [FieldOffset(352)] public float @intensityLimit;
    [FieldOffset(360)] public ResourcePointer @material;
    [FieldOffset(368)] public bool @selfIllum;
}

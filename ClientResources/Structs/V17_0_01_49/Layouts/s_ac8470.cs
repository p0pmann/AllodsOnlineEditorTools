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

[SerializedExtent(43)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_ac8470
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_ac7dc0))] public int @BlendEffect;
    [FieldOffset(8)] public ResourcePointer @diffuseTexture;
    [FieldOffset(16)] public NullablePointer @params;
    [FieldOffset(24)] public float @transparencyModifier;
    [FieldOffset(28)] public float @uTranslateSpeed;
    [FieldOffset(32)] public float @vTranslateSpeed;
    [FieldOffset(36)] public bool @scrollAlpha;
    [FieldOffset(37)] public bool @scrollRGB;
    [FieldOffset(38)] public bool @transparencyModifierIgnoreDiffuseAlpha;
    [FieldOffset(39)] public bool @transparent;
    [FieldOffset(40)] public bool @useFog;
    [FieldOffset(41)] public bool @useModifiers;
    [FieldOffset(42)] public bool @visible;
}

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

[StructSize(672)]
[XdbName("gameMechanics.constructor.schemes.item.VisualItem")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualItem
{
    [FieldOffset(40)] public Layouts.@s_c83070 @armorShapes;
    [FieldOffset(144)] public ResourcePointer @braTexturePatches;
    [FieldOffset(152, ArrayStride = 8)] public ResourcePointer[] @componentPacks;
    [FieldOffset(184, ArrayStride = 24)] public string[] @disabledGeosets;
    [FieldOffset(216)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @dressSlot;
    [FieldOffset(224)] public Layouts.@s_c83200 @dualWield;
    [FieldOffset(264, ArrayStride = 8)] public NullablePointer[] @dynamicComponents;
    [FieldOffset(296)] public NullablePointer @grades;
    [FieldOffset(304)] public Layouts.@s_c83310 @hiddenGeosets;
    [FieldOffset(408)] public Layouts.@s_c83310 @hiddenLocators;
    [FieldOffset(512)] public ResourcePointer @mainHandTrail;
    [FieldOffset(520, ArrayStride = 96)] public Layouts.@s_c82ee0[] @objects;
    [FieldOffset(552)] public ResourcePointer @pantsTexturePatches;
    [FieldOffset(560)][EnumRef(typeof(Enums.@e_c65760))] public int @sfxMaterial;
    [FieldOffset(568, ArrayStride = 8)] public NullablePointer[] @staticComponents;
    [FieldOffset(600)] public ResourcePointer @texturePatches;
    [FieldOffset(608)][EnumRef(typeof(Enums.@e_c83530))] public int @underwear;
    [FieldOffset(616)] public NullablePointer @visItemEffects;
    [FieldOffset(624)] public Layouts.@s_c821c0 @visualAliases;
    [FieldOffset(664)] public ResourcePointer @visualItemClass;
}

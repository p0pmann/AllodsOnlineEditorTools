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

[StructSize(472)]
[XdbName("CharacterVariations")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterVariations
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @additional;
    [FieldOffset(72)] public Layouts.@s_cb1ca0 @defaultVariation;
    [FieldOffset(208, ArrayStride = 8)] public ResourcePointer[] @faces;
    [FieldOffset(240, ArrayStride = 8)] public ResourcePointer[] @facial;
    [FieldOffset(272, ArrayStride = 8)] public ResourcePointer[] @hair;
    [FieldOffset(304, ArrayStride = 4)] public int[] @hairColors;
    [FieldOffset(336, ArrayStride = 8)] public ResourcePointer[] @mainTextures;
    [FieldOffset(368, ArrayStride = 4)] public int[] @shoulderStoneColors;
    [FieldOffset(400, ArrayStride = 8)] public ResourcePointer[] @shoulderStones;
    [FieldOffset(432, ArrayStride = 4)] public int[] @skinColors;
    [FieldOffset(464)] public bool @ignoreHairColor;
}

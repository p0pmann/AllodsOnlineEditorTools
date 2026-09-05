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

[SerializedExtent(252)]
[XdbName("gameMechanics.constructor.schemes.item.ItemBonus")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemBonus
{
    [FieldOffset(56, ArrayStride = 24)] public Layouts.@s_10d72b0[] @additionalSpecialStats;
    [FieldOffset(88)] public NullablePointer @cureFactor;
    [FieldOffset(96)] public NullablePointer @cureSummand;
    [FieldOffset(104)] public NullablePointer @powerFactor;
    [FieldOffset(112)] public NullablePointer @powerSummand;
    [FieldOffset(120)] public int @resistDivine;
    [FieldOffset(124)] public int @resistElemental;
    [FieldOffset(128)] public float @resistFactor;
    [FieldOffset(132)] public int @resistNature;
    [FieldOffset(136)] public NullablePointer @secondaryMajorFactor;
    [FieldOffset(144)] public NullablePointer @secondaryMinorFactor;
    [FieldOffset(152, ArrayStride = 4)][EnumRef(typeof(Enums.@e_158dc70))] public int[] @secondaryStats;
    [FieldOffset(184)] public NullablePointer @specialStatDefenceMod;
    [FieldOffset(192)] public NullablePointer @specialStatOffenceMod;
    [FieldOffset(200, ArrayStride = 8)] public ResourcePointer[] @specialStats;
    [FieldOffset(232)] public NullablePointer @staminaFactor;
    [FieldOffset(240)] public NullablePointer @staminaSummand;
    [FieldOffset(248)] public float @weaponDpsFactor;
}

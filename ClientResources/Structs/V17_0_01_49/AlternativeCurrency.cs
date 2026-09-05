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

[StructSize(216)]
[XdbName("gameMechanics.constructor.schemes.item.AlternativeCurrency")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AlternativeCurrency
{
    [FieldOffset(40)] public ResourcePointer @category;
    [FieldOffset(48, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public ResourcePointer @image;
    [FieldOffset(120)] public ResourcePointer @limitCurrency;
    [FieldOffset(128)] public int @maxValue;
    [FieldOffset(136)] public TextFileRef @name;
    [FieldOffset(168)] public ResourcePointer @sourceDescription;
    [FieldOffset(176)][EnumRef(typeof(Enums.@e_1529190))] public int @storage;
    [FieldOffset(184)] public string @sysName;
    [FieldOffset(208)][EnumRef(typeof(Enums.@e_15293e0))] public int @visualizeMode;
    [FieldOffset(212)] public bool @hideMaxValue;
    [FieldOffset(213)] public bool @isClientReplicated;
    [FieldOffset(214)] public bool @isCoupon;
}

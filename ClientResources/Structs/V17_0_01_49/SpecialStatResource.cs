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

[StructSize(312)]
[XdbName("gameMechanics.world.stats.specialStats.SpecialStatResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SpecialStatResource
{
    [FieldOffset(48, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @availableSlots;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_f91830))] public int @budgetType;
    [FieldOffset(88, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(120)] public TextFileRef @description;
    [FieldOffset(152, ArrayStride = 24)] public Layouts.@s_10d7b10[] @formulaModifiers;
    [FieldOffset(184)] public TextFileRef @shortDescription;
    [FieldOffset(216)] public NullablePointer @statMechanics;
    [FieldOffset(224)] public TextFileRef @statName;
    [FieldOffset(256)] public string @sysName;
    [FieldOffset(280)] public TextFileRef @tooltipName;
}

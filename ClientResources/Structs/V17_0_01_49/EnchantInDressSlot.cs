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

[SerializedExtent(56)]
[XdbName("gameMechanics.elements.item.EnchantInDressSlot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EnchantInDressSlot
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @dressSlot;
    [FieldOffset(48)][EnumRef(typeof(Enums.@e_1040220))] public int @enchantSlot;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_fefe10))] public int @type;
}

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

[SerializedExtent(124)]
[XdbName("gameMechanics.constructor.schemes.item.Enchant")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Enchant
{
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @attributes;
    [FieldOffset(88, ArrayStride = 4)][EnumRef(typeof(Enums.@e_158dc70))] public int[] @secondaryStats;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_1040220))] public int @slot;
}

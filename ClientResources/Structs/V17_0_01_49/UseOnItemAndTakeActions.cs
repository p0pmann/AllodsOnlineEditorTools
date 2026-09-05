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

[SerializedExtent(220)]
[XdbName("itemService.avatar.itemBag.UseOnItemAndTakeActions")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UseOnItemAndTakeActions
{
    [FieldOffset(48, ArrayStride = 4)][EnumRef(typeof(Enums.@e_11d8c40))] public int[] @allowedTargetSlotType;
    [FieldOffset(80)] public NullablePointer @highlightPredicate;
    [FieldOffset(88, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(120, ArrayStride = 152)] public Layouts.@s_11cb410[] @usages;
    [FieldOffset(152)] public int @useAmount;
    [FieldOffset(160)] public string @useCursor;
    [FieldOffset(184)] public TextFileRef @warningUseText;
    [FieldOffset(216)] public bool @isConvertible;
    [FieldOffset(217)] public bool @multipleUse;
    [FieldOffset(218)] public bool @useStack;
    [FieldOffset(219)] public bool @userChoice;
}

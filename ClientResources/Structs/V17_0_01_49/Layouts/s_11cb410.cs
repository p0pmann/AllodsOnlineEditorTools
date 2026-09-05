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

[SerializedExtent(152)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11cb410
{
    [FieldOffset(4)] public int @consumeTargetItem;
    [FieldOffset(8)] public int @consumeUsedItem;
    [FieldOffset(16)] public long @count;
    [FieldOffset(24)] public TextFileRef @desc;
    [FieldOffset(56)] public TextFileRef @entryWarningUseText;
    [FieldOffset(88)] public ResourcePointer @givenAltCurrency;
    [FieldOffset(96)] public ResourcePointer @givenItem;
    [FieldOffset(104)] public ResourcePointer @givenUnlock;
    [FieldOffset(112)] public ResourcePointer @image;
    [FieldOffset(120)] public NullablePointer @itemPredicate;
    [FieldOffset(128)] public NullablePointer @showPredicate;
    [FieldOffset(136)] public NullablePointer @usedItemPredicate;
    [FieldOffset(144)] public NullablePointer @warningItemPredicate;
}

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

[SerializedExtent(144)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1164070
{
    [FieldOffset(4)] public int @consumeUsedItem;
    [FieldOffset(8)] public long @count;
    [FieldOffset(16)] public TextFileRef @desc;
    [FieldOffset(48)] public TextFileRef @entryWarningUseText;
    [FieldOffset(80)] public ResourcePointer @givenAltCurrency;
    [FieldOffset(88)] public ResourcePointer @givenItem;
    [FieldOffset(96)] public ResourcePointer @givenUnlock;
    [FieldOffset(104)] public ResourcePointer @image;
    [FieldOffset(112)] public NullablePointer @itemPredicate;
    [FieldOffset(120)] public NullablePointer @showPredicate;
    [FieldOffset(128)] public NullablePointer @usedItemPredicate;
    [FieldOffset(136)] public NullablePointer @warningItemPredicate;
}

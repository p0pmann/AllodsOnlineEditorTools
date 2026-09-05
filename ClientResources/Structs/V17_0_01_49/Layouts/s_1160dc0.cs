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

[SerializedExtent(136)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1160dc0
{
    [FieldOffset(4)] public int @consumeItems;
    [FieldOffset(8)] public long @count;
    [FieldOffset(16)] public TextFileRef @desc;
    [FieldOffset(48)] public ResourcePointer @givenAltCurrency;
    [FieldOffset(56)] public ResourcePointer @givenUnlock;
    [FieldOffset(64)] public ResourcePointer @image;
    [FieldOffset(72)] public NullablePointer @itemPredicate;
    [FieldOffset(80)] public int @maxStack;
    [FieldOffset(88, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(120)] public NullablePointer @resultItem;
    [FieldOffset(128)] public NullablePointer @showPredicate;
}

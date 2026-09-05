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

[SerializedExtent(194)]
[XdbName("itemService.avatar.itemBag.UseItemChoice")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UseItemChoice
{
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @attributes;
    [FieldOffset(88, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(120, ArrayStride = 136)] public Layouts.@s_1160dc0[] @usages;
    [FieldOffset(152)] public int @useAmount;
    [FieldOffset(160)] public TextFileRef @warningUseText;
    [FieldOffset(192)] public bool @isConvertible;
    [FieldOffset(193)] public bool @useStack;
}

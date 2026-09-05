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

[SerializedExtent(170)]
[XdbName("itemService.avatar.itemBag.UseOnMountAndTakeActions")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UseOnMountAndTakeActions
{
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(80, ArrayStride = 120)] public Layouts.@s_1167070[] @usages;
    [FieldOffset(112)] public string @useCursor;
    [FieldOffset(136)] public TextFileRef @warningUseText;
    [FieldOffset(168)] public bool @multipleUse;
    [FieldOffset(169)] public bool @userChoice;
}

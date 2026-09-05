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

[SerializedExtent(120)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1167070
{
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @allowedMounts;
    [FieldOffset(40)] public int @consumeUsedItem;
    [FieldOffset(48)] public NullablePointer @mountPredicate;
    [FieldOffset(56)] public string @sysName;
    [FieldOffset(80)] public NullablePointer @usedItemPredicate;
    [FieldOffset(88)] public TextFileRef @warningUseText;
}

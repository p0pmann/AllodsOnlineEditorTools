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

[SerializedExtent(57)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_15da440
{
    [FieldOffset(8)] public NullablePointer @item;
    [FieldOffset(16)] public int @number;
    [FieldOffset(24, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(56)] public bool @hidden;
}

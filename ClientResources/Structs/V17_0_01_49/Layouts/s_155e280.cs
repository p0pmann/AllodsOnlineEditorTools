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

[SerializedExtent(72)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_155e280
{
    [FieldOffset(4)] public int @cost;
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @currencies;
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @predicates;
}

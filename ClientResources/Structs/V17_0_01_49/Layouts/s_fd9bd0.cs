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

[SerializedExtent(56)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_fd9bd0
{
    [FieldOffset(8, ArrayStride = 8)] public NullablePointer[] @conditions;
    [FieldOffset(40)] public int @count;
    [FieldOffset(48)] public ResourcePointer @item;
}

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

[SerializedExtent(112)]
[XdbName("ItemMallStatusCategoryMyCoupon")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemMallStatusCategoryMyCoupon
{
    [FieldOffset(40)] public ResourcePointer @category;
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @statuses;
}

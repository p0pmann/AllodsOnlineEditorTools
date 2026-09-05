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

[StructSize(152)]
[XdbName("ItemMall")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemMall
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @categories;
    [FieldOffset(72)] public ResourcePointer @contextItemsCategory;
    [FieldOffset(80)] public ResourcePointer @currencyDescriptions;
    [FieldOffset(88)] public ResourcePointer @dressItemsCategory;
    [FieldOffset(96)] public ResourcePointer @favorites;
    [FieldOffset(104)] public ResourcePointer @premium;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @statusCategories;
    [FieldOffset(144)] public bool @isP2P;
}

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

[StructSize(112)]
[XdbName("itemService.basicInterfaces.itemmall.resources.ItemMallRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemMallRoot
{
    [FieldOffset(40, ArrayStride = 80)] public Layouts.@s_11c59d0[] @contextMetaEnhancers;
    [FieldOffset(72, ArrayStride = 40)] public Layouts.@s_fd9780[] @contextTradeItems;
    [FieldOffset(104)] public ResourcePointer @couponsRegistry;
}

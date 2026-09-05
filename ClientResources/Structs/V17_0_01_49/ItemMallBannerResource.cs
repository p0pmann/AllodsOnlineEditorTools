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

[StructSize(144)]
[XdbName("itemService.itemmall.resources.ItemMallBannerResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemMallBannerResource
{
    [FieldOffset(40)] public TextFileRef @ExternalURL;
    [FieldOffset(72)] public TextFileRef @URL;
    [FieldOffset(104)] public TextFileRef @description;
    [FieldOffset(136)] public ResourcePointer @image;
}

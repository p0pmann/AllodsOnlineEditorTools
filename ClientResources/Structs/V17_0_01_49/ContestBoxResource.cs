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

[StructSize(88)]
[XdbName("itemService.contestBox.ContestBoxResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ContestBoxResource
{
    [FieldOffset(40)] public ResourcePointer @contestResource;
    [FieldOffset(48)] public ResourcePointer @image;
    [FieldOffset(56, ArrayStride = 32)] public Layouts.@s_10ab170[] @prizeBanners;
}

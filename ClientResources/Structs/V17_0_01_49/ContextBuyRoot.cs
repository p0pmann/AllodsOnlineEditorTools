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

[StructSize(72)]
[XdbName("itemService.basicElements.ContextBuyRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ContextBuyRoot
{
    [FieldOffset(40, ArrayStride = 80)] public Layouts.@s_fd72d0[] @tradableItems;
}

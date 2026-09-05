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
[XdbName("itemService.elements.targetSales.TargetSaleResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TargetSaleResource
{
    [FieldOffset(40, ArrayStride = 72)] public Layouts.@s_10e3e70[] @entries;
}

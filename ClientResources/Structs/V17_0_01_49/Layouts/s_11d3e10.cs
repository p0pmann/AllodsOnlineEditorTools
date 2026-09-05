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

[SerializedExtent(49)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11d3e10
{
    [FieldOffset(8)] public ResourcePointer @coupon;
    [FieldOffset(16, ArrayStride = 24)] public Layouts.@s_15aed00[] @items;
    [FieldOffset(48)] public bool @invisibleWithoutCoupon;
}

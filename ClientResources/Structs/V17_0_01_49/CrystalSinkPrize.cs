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

[StructSize(96)]
[XdbName("itemService.elements.crystalsink.CrystalSinkPrize")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CrystalSinkPrize
{
    [FieldOffset(36)] public float @cost;
    [FieldOffset(40)] public ResourcePointer @item;
    [FieldOffset(48)] public int @maxStackCount;
    [FieldOffset(56, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(88)] public bool @bound;
    [FieldOffset(89)] public bool @superPrize;
    [FieldOffset(90)] public bool @superPrizeBound;
}

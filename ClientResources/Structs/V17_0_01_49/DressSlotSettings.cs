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
[XdbName("DressSlotSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DressSlotSettings
{
    [FieldOffset(40, ArrayStride = 72)] public Layouts.@s_d10160[] @addedComponents;
    [FieldOffset(72)] public ResourcePointer @emptyVisItem;
    [FieldOffset(80, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @slotOrder;
    [FieldOffset(112, ArrayStride = 16)] public Layouts.@s_d10290[] @visItemFallbacks;
}

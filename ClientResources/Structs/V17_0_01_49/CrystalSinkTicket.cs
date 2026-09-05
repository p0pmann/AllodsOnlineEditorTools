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

[StructSize(56)]
[XdbName("itemService.elements.crystalsink.CrystalSinkTicket")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CrystalSinkTicket
{
    [FieldOffset(36)] public float @cost;
    [FieldOffset(40)] public ResourcePointer @item;
    [FieldOffset(48)] public int @score;
}

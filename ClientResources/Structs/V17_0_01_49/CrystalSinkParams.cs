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
[XdbName("itemService.elements.crystalsink.CrystalSinkParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CrystalSinkParams
{
    [FieldOffset(36)] public int @poolSize;
    [FieldOffset(40)] public int @prizeListSize;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @prizes;
    [FieldOffset(80)] public ResourcePointer @scoreIndicator;
    [FieldOffset(88)] public ResourcePointer @supePrizeCountIndicator;
    [FieldOffset(96)] public int @superPrizesPerDay;
    [FieldOffset(104)] public ResourcePointer @ticket;
}

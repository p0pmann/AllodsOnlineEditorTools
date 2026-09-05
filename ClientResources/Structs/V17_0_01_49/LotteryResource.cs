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

[StructSize(128)]
[XdbName("itemService.elements.lottery.LotteryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LotteryResource
{
    [FieldOffset(40, ArrayStride = 40)] public Layouts.@s_106c910[] @consolationPrizes;
    [FieldOffset(72)] public int @maxWinners;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @prizes;
    [FieldOffset(112)] public ResourcePointer @ticketCounter;
    [FieldOffset(120)] public ResourcePointer @ticketResource;
}

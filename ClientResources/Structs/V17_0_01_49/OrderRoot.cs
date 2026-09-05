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

[StructSize(192)]
[XdbName("order.OrderRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @OrderRoot
{
    [FieldOffset(40)] public ResourcePointer @leaveOrderSpell;
    [FieldOffset(48)] public ResourcePointer @orderAccessQuest;
    [FieldOffset(56, ArrayStride = 8)] public ResourcePointer[] @orderBonuses;
    [FieldOffset(88, ArrayStride = 8)] public ResourcePointer[] @orders;
    [FieldOffset(120)] public int @prestigeTopLimit;
    [FieldOffset(128)] public ResourcePointer @ratingEvent;
    [FieldOffset(136)] public int @ratingTopLimit;
    [FieldOffset(144)] public ResourcePointer @seasonEvent;
    [FieldOffset(152)] public ResourcePointer @seasonWeek;
    [FieldOffset(160)] public int @storedVotes;
    [FieldOffset(168)] public ResourcePointer @trainingEvent;
    [FieldOffset(176)] public ResourcePointer @voteEvent;
    [FieldOffset(184)] public int @voteForVariants;
    [FieldOffset(188)] public int @voteWinPositions;
}

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
[XdbName("gameMechanics.world.gameRoot.QuestRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestRoot
{
    [FieldOffset(40)] public NullablePointer @cursendDestinyPointScaler;
    [FieldOffset(48)] public NullablePointer @destinyPointScaler;
    [FieldOffset(56)] public ResourcePointer @nextQuestFinder;
    [FieldOffset(64)] public int @onRequestShareDuration;
    [FieldOffset(68)] public int @onStartShareDuration;
    [FieldOffset(72)] public float @shareRange;
    [FieldOffset(80)] public ResourcePointer @skipQuestKey;
    [FieldOffset(88)] public NullablePointer @skipQuestMaxLevel;
    [FieldOffset(96)] public NullablePointer @skipQuestPriceScaler;
    [FieldOffset(104)] public ResourcePointer @worldSecrets;
}

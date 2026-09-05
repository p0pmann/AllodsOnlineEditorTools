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

[SerializedExtent(240)]
[XdbName("gameMechanics.constructor.schemes.quest.QuestRewardSimple")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestRewardSimple
{
    [FieldOffset(48, ArrayStride = 64)] public Layouts.@s_15da440[] @alternativeItems;
    [FieldOffset(80, ArrayStride = 56)] public Layouts.@s_15da2e0[] @currencies;
    [FieldOffset(112)] public int @experience;
    [FieldOffset(120)] public NullablePointer @guildAuthorityScaler;
    [FieldOffset(128)] public NullablePointer @guildLoyaltyCalcer;
    [FieldOffset(136, ArrayStride = 64)] public Layouts.@s_15da440[] @mandatoryItems;
    [FieldOffset(168)] public int @money;
    [FieldOffset(176, ArrayStride = 24)] public Layouts.@s_15da4f0[] @reputations;
    [FieldOffset(208, ArrayStride = 8)] public ResourcePointer[] @unlocks;
}

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

[StructSize(1184)]
[XdbName("GMUIHelper")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GMUIHelper
{
    [FieldOffset(40, ArrayStride = 40)] public Layouts.@s_6f28e0[] @abilitiesAliases;
    [FieldOffset(72)] public ResourcePointer @aedRace;
    [FieldOffset(80, ArrayStride = 48)] public Layouts.@s_6f2b20[] @allowedTags;
    [FieldOffset(112)] public ResourcePointer @antiFlood;
    [FieldOffset(120)] public ResourcePointer @antiSpam;
    [FieldOffset(128)] public Layouts.@s_950650 @auctionFilter;
    [FieldOffset(216)] public ResourcePointer @castbarGroup;
    [FieldOffset(224)] public ResourcePointer @checkRoomRoot;
    [FieldOffset(232)] public TextFileRef @chestOpening;
    [FieldOffset(264)] public Layouts.@s_951610 @classSpecificData;
    [FieldOffset(312)] public TextFileRef @completeQuestText;
    [FieldOffset(344)] public ResourcePointer @conditionEvents;
    [FieldOffset(352)] public ResourcePointer @contextActions;
    [FieldOffset(360, ArrayStride = 8)] public ResourcePointer[] @currencies;
    [FieldOffset(392, ArrayStride = 48)] public Layouts.@s_6f2b20[] @deniedTags;
    [FieldOffset(424, ArrayStride = 8)] public ResourcePointer[] @detectors;
    [FieldOffset(456)] public ResourcePointer @elfRace;
    [FieldOffset(464)] public ResourcePointer @empireFaction;
    [FieldOffset(472, ArrayStride = 8)] public ResourcePointer[] @engineerAssistentSpells;
    [FieldOffset(504)] public Layouts.@s_9553b0 @equipmentData;
    [FieldOffset(544)] public ResourcePointer @escapeDungeonSpell;
    [FieldOffset(552, ArrayStride = 8)] public ResourcePointer[] @forgeGoldenSlots;
    [FieldOffset(584, ArrayStride = 8)] public ResourcePointer[] @forgeResources;
    [FieldOffset(616)] public ResourcePointer @freeKeysSpell;
    [FieldOffset(624)] public TextFileRef @gameItemCompositNameSpace;
    [FieldOffset(656)] public ResourcePointer @gameStateRoot;
    [FieldOffset(664)] public ResourcePointer @gibberlingRace;
    [FieldOffset(672)] public ResourcePointer @hadaganRace;
    [FieldOffset(680)] public ResourcePointer @heroesArenaQuitSpell;
    [FieldOffset(688)] public ResourcePointer @heroesArenaStarnStageSpell;
    [FieldOffset(696)] public ResourcePointer @interfaceMaps;
    [FieldOffset(704)] public ResourcePointer @itemMall;
    [FieldOffset(712)] public ResourcePointer @itemMallP2P;
    [FieldOffset(720)] public ResourcePointer @kaniaRace;
    [FieldOffset(728)] public ResourcePointer @leagueFaction;
    [FieldOffset(736)] public ResourcePointer @notifications;
    [FieldOffset(744)] public ResourcePointer @orcRace;
    [FieldOffset(752)] public ResourcePointer @poweredLSWeaponsRoot;
    [FieldOffset(760, ArrayStride = 8)] public ResourcePointer[] @pridenFactions;
    [FieldOffset(792)] public ResourcePointer @pridenRace;
    [FieldOffset(800, ArrayStride = 8)] public ResourcePointer[] @psionicAssistentSpells;
    [FieldOffset(832)] public ResourcePointer @ratingArena3x3;
    [FieldOffset(840)] public ResourcePointer @ratingArena6x6;
    [FieldOffset(848)] public ResourcePointer @ratingHPI;
    [FieldOffset(856)] public ResourcePointer @referralContentKey;
    [FieldOffset(864, ArrayStride = 8)] public ResourcePointer[] @reforgeDefResources;
    [FieldOffset(896, ArrayStride = 8)] public ResourcePointer[] @reforgeOffResources;
    [FieldOffset(928, ArrayStride = 8)] public ResourcePointer[] @remindedTemporaryUnlocks;
    [FieldOffset(960, ArrayStride = 8)] public ResourcePointer[] @riftMaps;
    [FieldOffset(992)] public ResourcePointer @ruleNews;
    [FieldOffset(1000)] public ResourcePointer @runProceduralDungeonScenarioSpell;
    [FieldOffset(1008)] public ResourcePointer @setBonusRoot;
    [FieldOffset(1016)] public ResourcePointer @slashCommands;
    [FieldOffset(1024)] public ResourcePointer @stopProceduralDungeonScenarioSpell;
    [FieldOffset(1032)] public ResourcePointer @tutorialRoot;
    [FieldOffset(1040)] public ResourcePointer @undeadRace;
    [FieldOffset(1048)] public Layouts.@s_6f2cc0 @unlocksSpecial;
    [FieldOffset(1136)] public Layouts.@s_6f2d90 @unstuckSpell;
    [FieldOffset(1160)] public ResourcePointer @variablesAliases;
    [FieldOffset(1168)] public ResourcePointer @veteranRewards;
    [FieldOffset(1176)] public float @warningLowStatPercent;
}

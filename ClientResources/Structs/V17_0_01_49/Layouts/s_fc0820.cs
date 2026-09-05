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

[SerializedExtent(328)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_fc0820
{
    [FieldOffset(8, ArrayStride = 64)] public Layouts.@s_fc23d0[] @bossQuestsEmpire;
    [FieldOffset(40, ArrayStride = 64)] public Layouts.@s_fc23d0[] @bossQuestsLeague;
    [FieldOffset(72)] public ResourcePointer @clanHallTalents;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @creationPredicates;
    [FieldOffset(112, ArrayStride = 64)] public Layouts.@s_fc23d0[] @creationQuests;
    [FieldOffset(144)] public long @dailyExpCap;
    [FieldOffset(152, ArrayStride = 64)] public Layouts.@s_fc23d0[] @dailyQuestsEmpire;
    [FieldOffset(184, ArrayStride = 64)] public Layouts.@s_fc23d0[] @dailyQuestsLeague;
    [FieldOffset(216)] public ResourcePointer @guildHallTeleport;
    [FieldOffset(224, ArrayStride = 8)] public ResourcePointer[] @hallCategories;
    [FieldOffset(256)] public int @minMembers;
    [FieldOffset(264, ArrayStride = 16)] public Layouts.@s_1010b10[] @progressStages;
    [FieldOffset(296, ArrayStride = 8)] public ResourcePointer[] @settings;
}

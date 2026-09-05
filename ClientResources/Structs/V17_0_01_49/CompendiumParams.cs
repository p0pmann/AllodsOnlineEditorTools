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

[StructSize(208)]
[XdbName("itemService.compendium.CompendiumParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CompendiumParams
{
    [FieldOffset(40)] public NullablePointer @bonusLevelEntry;
    [FieldOffset(48, ArrayStride = 8)] public NullablePointer[] @levelEntries;
    [FieldOffset(80)] public int @minAvatarLevel;
    [FieldOffset(88)] public ResourcePointer @questSkipper;
    [FieldOffset(96)] public ResourcePointer @scoreIndicator;
    [FieldOffset(104, ArrayStride = 48)] public Layouts.@s_fcab80[] @territoryGoalRewards;
    [FieldOffset(136, ArrayStride = 48)] public Layouts.@s_fcac60[] @territoryQuestChains;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @ticketRewards;
    [FieldOffset(200)] public ResourcePointer @unlock;
}

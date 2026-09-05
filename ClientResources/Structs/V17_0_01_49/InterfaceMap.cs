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

[StructSize(320)]
[XdbName("InterfaceMap")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceMap
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @finalQuest;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @mapResources;
    [FieldOffset(112)] public ResourcePointer @markerObjects;
    [FieldOffset(120)] public int @maxComfortLevel;
    [FieldOffset(124)] public int @minComfortLevel;
    [FieldOffset(128)] public TextFileRef @name;
    [FieldOffset(160)] public ResourcePointer @otherQuestsMap;
    [FieldOffset(168, ArrayStride = 8)] public NullablePointer[] @presencePredicates;
    [FieldOffset(200)] public ResourcePointer @quests;
    [FieldOffset(208, ArrayStride = 8)] public NullablePointer[] @showPredicates;
    [FieldOffset(240)] public string @sysName;
    [FieldOffset(264)] public ResourcePointer @texture;
    [FieldOffset(272)] public int @zoneCeil;
    [FieldOffset(276)] public int @zoneFloor;
    [FieldOffset(280, ArrayStride = 88)] public Layouts.@s_6727f0[] @zoneInsets;
    [FieldOffset(312)] public bool @showInList;
    [FieldOffset(313)] public bool @showPositions;
    [FieldOffset(314)] public bool @showQuestProgress;
}

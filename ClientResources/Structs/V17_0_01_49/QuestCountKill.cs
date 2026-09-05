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

[SerializedExtent(352)]
[XdbName("gameMechanics.elements.quest.QuestCountKill")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestCountKill
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @autoRelatedItems;
    [FieldOffset(72)] public TextFileRef @customName;
    [FieldOffset(104)] public TextFileRef @description;
    [FieldOffset(136, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @dressSlots;
    [FieldOffset(168)] public int @limit;
    [FieldOffset(176, ArrayStride = 48)] public Layouts.@s_11d2e70[] @locations;
    [FieldOffset(208, ArrayStride = 24)] public Layouts.@s_11dbd00[] @lootTables;
    [FieldOffset(240, ArrayStride = 8)] public ResourcePointer[] @relatedItems;
    [FieldOffset(272, ArrayStride = 8)] public ResourcePointer[] @relatedMobsAndDevices;
    [FieldOffset(304)] public bool @alwaysShowMarker;
    [FieldOffset(305)] public bool @alwaysShowRelatedMobsAndDevices;
    [FieldOffset(306)] public bool @isInternal;
    [FieldOffset(307)] public bool @showCounterValue;
    [FieldOffset(320, ArrayStride = 8)] public ResourcePointer[] @objects;
}

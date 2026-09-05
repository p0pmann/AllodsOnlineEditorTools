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

[SerializedExtent(204)]
[XdbName("gameMechanics.interactions.common.Interactions")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Interactions
{
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_11d8c40))] public int[] @accessorFor;
    [FieldOffset(72)] public ResourcePointer @auction;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @availableQuests;
    [FieldOffset(112, ArrayStride = 16)] public Layouts.@s_1590940[] @cues;
    [FieldOffset(144, ArrayStride = 4)][EnumRef(typeof(Enums.@e_1590a10))] public int[] @extended;
    [FieldOffset(176)] public NullablePointer @teleportMaster;
    [FieldOffset(184)] public NullablePointer @trainer;
    [FieldOffset(192)] public ResourcePointer @vendorTable;
    [FieldOffset(200)] public bool @changeRoomMaster;
    [FieldOffset(201)] public bool @isMailBox;
    [FieldOffset(202)] public bool @isMetaItemUpgrader;
    [FieldOffset(203)] public bool @remortMaster;
}

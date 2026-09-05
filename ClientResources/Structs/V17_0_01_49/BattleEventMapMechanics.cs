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

[StructSize(144)]
[XdbName("gameMechanics.battleground.BattleEventMapMechanics")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BattleEventMapMechanics
{
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_1189be0[] @achievements;
    [FieldOffset(72)] public Layouts.@s_122d150 @duration;
    [FieldOffset(96)][EnumRef(typeof(Enums.@e_11dc300))] public int @mechanicsType;
    [FieldOffset(100)] public Layouts.@s_122d150 @roundDuration;
    [FieldOffset(124)] public int @roundsCount;
    [FieldOffset(128)] public ResourcePointer @score;
    [FieldOffset(136)] public int @winCounter;
    [FieldOffset(140)] public bool @hideMembersList;
    [FieldOffset(141)] public bool @isGetRatingsAllowed;
    [FieldOffset(142)] public bool @isInspectAllowed;
}

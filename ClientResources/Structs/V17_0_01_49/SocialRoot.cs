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

[StructSize(168)]
[XdbName("gameMechanics.world.gameRoot.SocialRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SocialRoot
{
    [FieldOffset(36)] public int @avatarSaveMapWarningTimeout;
    [FieldOffset(40)] public Layouts.@s_122d150 @inviteTimeout;
    [FieldOffset(64)] public int @maxGroupCountInRaid;
    [FieldOffset(68)] public int @maxGroupCountInSmallRaid;
    [FieldOffset(72)] public int @maxGroupSize;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @notSocializedFactions;
    [FieldOffset(112)] public int @readyCheckTimeout;
    [FieldOffset(120)] public ResourcePointer @reputationTable;
    [FieldOffset(128, ArrayStride = 24)] public Layouts.@s_15fe730[] @reputationTables;
    [FieldOffset(160)] public float @weakFactionExpFactor;
}

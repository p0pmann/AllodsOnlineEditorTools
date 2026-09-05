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

[StructSize(184)]
[XdbName("gameMechanics.world.gameRoot.AvatarRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AvatarRoot
{
    [FieldOffset(48, ArrayStride = 40)] public Layouts.@s_1532040[] @avatarLevels;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @gearScoreLevelsByPass;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @gearScoreLevelsByRecipe;
    [FieldOffset(144)] public ResourcePointer @myrrh;
    [FieldOffset(152)] public ResourcePointer @ruby;
    [FieldOffset(160)] public float @secsToMyrrhFactor;
    [FieldOffset(168)] public ResourcePointer @statPoint;
    [FieldOffset(176)] public ResourcePointer @talentPoint;
}

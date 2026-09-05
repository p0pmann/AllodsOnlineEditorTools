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

[StructSize(104)]
[XdbName("gameMechanics.world.gameRoot.MentorRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MentorRoot
{
    [FieldOffset(40, ArrayStride = 72)] public Layouts.@s_11dce00[] @itemReward;
    [FieldOffset(72, ArrayStride = 20)] public Layouts.@s_11dcea0[] @moneyReward;
}

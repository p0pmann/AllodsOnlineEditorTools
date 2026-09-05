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
[XdbName("gameMechanics.world.gameRoot.PremiumStageEntry")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PremiumStageEntry
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @buffs;
    [FieldOffset(72)] public TextFileRef @description;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @items;
    [FieldOffset(136)] public int @requiredDonate;
    [FieldOffset(140)] public int @stageNumber;
}

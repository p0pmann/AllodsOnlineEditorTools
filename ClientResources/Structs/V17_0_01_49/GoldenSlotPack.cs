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

[StructSize(112)]
[XdbName("gameMechanics.world.gameRoot.GoldenSlotPack")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GoldenSlotPack
{
    [FieldOffset(40)] public ResourcePointer @characterClass;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @items;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @spells;
}

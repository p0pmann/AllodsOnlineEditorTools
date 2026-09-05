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

[StructSize(88)]
[XdbName("gameMechanics.world.gameRoot.BestFriendsRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BestFriendsRoot
{
    [FieldOffset(40)] public ResourcePointer @contentKey;
    [FieldOffset(48)] public ResourcePointer @lendShipSpell;
    [FieldOffset(56)] public ResourcePointer @returnShipSpell;
    [FieldOffset(64)] public ResourcePointer @returnSpell;
    [FieldOffset(72)] public ResourcePointer @takeAwayShipSpell;
    [FieldOffset(80)] public ResourcePointer @teleportSpell;
}

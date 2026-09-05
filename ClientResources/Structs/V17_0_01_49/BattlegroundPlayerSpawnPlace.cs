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
[XdbName("gameMechanics.battleground.BattlegroundPlayerSpawnPlace")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BattlegroundPlayerSpawnPlace
{
    [FieldOffset(48)] public ResourcePointer @image;
    [FieldOffset(56)] public string @sysName;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_ff5cd0))] public int @team;
}

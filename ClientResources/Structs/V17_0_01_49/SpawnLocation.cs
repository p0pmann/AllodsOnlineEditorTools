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

[SerializedExtent(72)]
[XdbName("gameMechanics.map.spawn.SpawnLocation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SpawnLocation
{
    [FieldOffset(36)] public BigVector3 @position;
    [FieldOffset(64)] public ResourcePointer @zone;
}

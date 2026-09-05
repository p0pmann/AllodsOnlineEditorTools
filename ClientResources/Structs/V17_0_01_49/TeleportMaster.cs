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

[SerializedExtent(56)]
[XdbName("gameMechanics.interactions.teleportmaster.TeleportMaster")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TeleportMaster
{
    [FieldOffset(40)] public ResourcePointer @location;
    [FieldOffset(48)] public ResourcePointer @unlock;
}

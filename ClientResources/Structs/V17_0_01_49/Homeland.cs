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

[StructSize(56)]
[XdbName("gameMechanics.map.zone.Homeland")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Homeland
{
    [FieldOffset(36)] public bool @isInvitesAllowed;
    [FieldOffset(48)] public ResourcePointer @faction;
}

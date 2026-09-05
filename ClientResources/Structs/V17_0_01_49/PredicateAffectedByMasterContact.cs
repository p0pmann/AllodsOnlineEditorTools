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

[SerializedExtent(49)]
[XdbName("gameMechanics.elements.predicates.PredicateAffectedByMasterContact")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateAffectedByMasterContact
{
    [FieldOffset(36)] public bool @hideText;
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_15ca350))] public int @contactType;
    [FieldOffset(48)] public bool @checkContactType;
}

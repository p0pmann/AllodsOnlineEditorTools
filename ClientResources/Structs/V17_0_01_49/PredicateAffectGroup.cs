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

[SerializedExtent(48)]
[XdbName("gameMechanics.elements.predicates.PredicateAffectGroup")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateAffectGroup
{
    [FieldOffset(36)] public bool @hideText;
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_171fe40))] public int @affectGroup;
}

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

[SerializedExtent(57)]
[XdbName("gameMechanics.elements.predicates.PredicateHasPsionicContact")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateHasPsionicContact
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_15ca350))] public int @type;
    [FieldOffset(56)] public bool @spellTarget;
}

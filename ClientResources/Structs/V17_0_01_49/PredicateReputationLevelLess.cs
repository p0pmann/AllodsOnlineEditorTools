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

[SerializedExtent(68)]
[XdbName("gameMechanics.elements.predicates.PredicateReputationLevelLess")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateReputationLevelLess
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56)] public ResourcePointer @faction;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_15e6280))] public int @level;
}

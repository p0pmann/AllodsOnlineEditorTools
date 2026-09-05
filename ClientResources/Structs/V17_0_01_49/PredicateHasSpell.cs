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

[SerializedExtent(65)]
[XdbName("gameMechanics.elements.predicates.PredicateHasSpell")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateHasSpell
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56)] public ResourcePointer @spell;
    [FieldOffset(64)] public bool @anyRank;
}

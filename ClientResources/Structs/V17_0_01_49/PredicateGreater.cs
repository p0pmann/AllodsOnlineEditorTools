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

[SerializedExtent(76)]
[XdbName("gameMechanics.elements.predicates.PredicateGreater")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateGreater
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56)] public NullablePointer @lhs;
    [FieldOffset(64)] public NullablePointer @rhs;
    [FieldOffset(72)] public float @threshold;
}

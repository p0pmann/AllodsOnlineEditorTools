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

[SerializedExtent(92)]
[XdbName("gameMechanics.elements.predicates.PredicateNear")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateNear
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(88)] public float @radius;
}

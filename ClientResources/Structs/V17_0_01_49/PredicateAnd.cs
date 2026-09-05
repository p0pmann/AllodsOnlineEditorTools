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

[SerializedExtent(88)]
[XdbName("gameMechanics.constructor.basicElements.PredicateAnd")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateAnd
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56, ArrayStride = 8)] public NullablePointer[] @predicates;
}

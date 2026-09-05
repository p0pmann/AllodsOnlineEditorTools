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

[SerializedExtent(90)]
[XdbName("gameMechanics.elements.predicates.PredicateHasBuffFromGroup")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateHasBuffFromGroup
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(88)] public bool @checkHarmful;
    [FieldOffset(89)] public bool @checkHelpful;
}

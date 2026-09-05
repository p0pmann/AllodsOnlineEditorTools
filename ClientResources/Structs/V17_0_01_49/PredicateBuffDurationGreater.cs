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

[SerializedExtent(62)]
[XdbName("gameMechanics.elements.predicates.PredicateBuffDurationGreater")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateBuffDurationGreater
{
    [FieldOffset(36)] public bool @hideText;
    [FieldOffset(48)] public ResourcePointer @buff;
    [FieldOffset(56)] public int @duration;
    [FieldOffset(60)] public bool @anyRank;
    [FieldOffset(61)] public bool @checkCaster;
}

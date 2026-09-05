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

[SerializedExtent(106)]
[XdbName("PredicateCreatureVisCharacterAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateCreatureVisCharacterAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @visCharList;
    [FieldOffset(104)] public bool @checkIsInTheList;
    [FieldOffset(105)] public bool @checkOnStartOnly;
}

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
[XdbName("RelationshipAttachVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RelationshipAttachVisAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public NullablePointer @enemyVisAction;
    [FieldOffset(80)] public NullablePointer @friendVisAction;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
}

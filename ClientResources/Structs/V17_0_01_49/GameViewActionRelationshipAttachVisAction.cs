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

[SerializedExtent(228)]
[XdbName("GameViewActionRelationshipAttachVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionRelationshipAttachVisAction
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @enemyCreature;
    [FieldOffset(184)] public NullablePointer @enemyVisAction;
    [FieldOffset(192)] public string @friendCreature;
    [FieldOffset(216)] public NullablePointer @friendVisAction;
    [FieldOffset(224)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
}

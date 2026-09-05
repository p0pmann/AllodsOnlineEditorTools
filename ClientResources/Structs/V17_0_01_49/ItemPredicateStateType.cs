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

[SerializedExtent(48)]
[XdbName("gameMechanics.constructor.schemes.item.ItemPredicateStateType")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemPredicateStateType
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_102e790))] public int @type;
}

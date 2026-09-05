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

[SerializedExtent(73)]
[XdbName("CreatureGeometryModifierAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureGeometryModifierAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(72)] public bool @fadeByCameraCollision;
}

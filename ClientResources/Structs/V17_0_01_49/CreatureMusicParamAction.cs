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

[SerializedExtent(100)]
[XdbName("CreatureMusicParamAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureMusicParamAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public NullablePointer @creatureParameter;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_11a5e30))] public int @fromCreature;
    [FieldOffset(88)] public ResourcePointer @parameter;
    [FieldOffset(96)] public float @value;
}

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

[SerializedExtent(77)]
[XdbName("CreatureHoldWeaponAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureHoldWeaponAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_176f4a0))] public int @hold;
    [FieldOffset(72)] public float @time;
    [FieldOffset(76)] public bool @boast;
}

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
[XdbName("SimpleClientMob")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SimpleClientMob
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(48)] public Vector3 @position;
    [FieldOffset(64)] public ResourcePointer @visualMob;
    [FieldOffset(72)] public float @yaw;
    [FieldOffset(76)] public bool @alwaysWithWeapon;
}

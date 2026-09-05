// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(114)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_15fd070
{
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @allowedDeviceTypes;
    [FieldOffset(40)] public Vector3 @coord;
    [FieldOffset(56)] public NullablePointer @interfaceData;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_1210e30))] public int @name;
    [FieldOffset(68)] public float @pitch;
    [FieldOffset(72)] public float @pitchRange;
    [FieldOffset(76)] public float @roll;
    [FieldOffset(80)] public Quaternion @rotation;
    [FieldOffset(96)] public float @scale;
    [FieldOffset(100)][EnumRef(typeof(Enums.@e_15fafb0))] public int @side;
    [FieldOffset(104)] public float @yaw;
    [FieldOffset(108)] public float @yawRange;
    [FieldOffset(112)] public bool @canBeEmpty;
    [FieldOffset(113)] public bool @isLootSlot;
}

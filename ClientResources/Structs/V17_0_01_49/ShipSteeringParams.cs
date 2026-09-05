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

[StructSize(64)]
[XdbName("ShipSteeringParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipSteeringParams
{
    [FieldOffset(36)] public float @agility;
    [FieldOffset(40)] public float @maxPitch;
    [FieldOffset(44)] public float @maxRoll;
    [FieldOffset(48)] public float @pitchMul;
    [FieldOffset(52)] public float @rollMul;
    [FieldOffset(56)] public float @shakeAmplitude;
    [FieldOffset(60)] public float @shakePeriod;
}

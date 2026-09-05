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

[SerializedExtent(61)]
[XdbName("gameMechanics.world.device.LinearMalfunctionCalcer")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LinearMalfunctionCalcer
{
    [FieldOffset(44)] public float @b;
    [FieldOffset(48)] public float @k;
    [FieldOffset(52)] public float @treshold;
    [FieldOffset(56)] public float @value;
    [FieldOffset(60)] public bool @inverted;
}

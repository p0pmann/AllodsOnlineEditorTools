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

[SerializedExtent(120)]
[XdbName("gameMechanics.world.ship.ShipUnit")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipUnit
{
    [FieldOffset(48)] public ResourcePointer @category;
    [FieldOffset(56, ArrayStride = 24)] public Layouts.@s_fc35f0[] @clientDevices;
    [FieldOffset(88)] public ResourcePointer @deviceType;
    [FieldOffset(96)] public NullablePointer @mass;
    [FieldOffset(104)] public ResourcePointer @usableDevice;
    [FieldOffset(112)] public ResourcePointer @visualItem;
}

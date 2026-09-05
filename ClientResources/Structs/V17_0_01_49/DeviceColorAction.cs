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

[SerializedExtent(108)]
[XdbName("DeviceColorAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceColorAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(76)] public Quaternion @colorFactor;
    [FieldOffset(92)] public int @colorValue;
    [FieldOffset(96)] public int @priority;
    [FieldOffset(100)] public float @timeOff;
    [FieldOffset(104)] public float @timeOn;
}

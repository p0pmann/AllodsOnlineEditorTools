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

[SerializedExtent(124)]
[XdbName("DeviceChannelAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceChannelAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public ResourcePointer @channelingFx;
    [FieldOffset(88)] public NullablePointer @endPoint;
    [FieldOffset(96)] public int @fadeInTime;
    [FieldOffset(100)] public int @fadeOutTime;
    [FieldOffset(104)] public float @fxLength;
    [FieldOffset(112)] public NullablePointer @startPoint;
    [FieldOffset(120)] public float @velocity;
}

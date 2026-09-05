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

[SerializedExtent(80)]
[XdbName("DeviceOfflineComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceOfflineComponent
{
    [FieldOffset(48)] public NullablePointer @malfunctionScript;
    [FieldOffset(56)] public NullablePointer @offlineScript;
    [FieldOffset(64)] public NullablePointer @onlineScript;
    [FieldOffset(72)] public NullablePointer @overheatScript;
}

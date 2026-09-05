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

[SerializedExtent(96)]
[XdbName("DeviceVisActionLoopAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceVisActionLoopAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public NullablePointer @actionToLoop;
    [FieldOffset(88)] public int @repeat;
    [FieldOffset(92)] public float @totalTime;
}

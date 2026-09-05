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

[SerializedExtent(132)]
[XdbName("DeviceCannonLaunchedAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceCannonLaunchedAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public ResourcePointer @explosionFx;
    [FieldOffset(88, ArrayStride = 16)] public Layouts.@s_177bdb0[] @lines;
    [FieldOffset(120)] public ResourcePointer @projectileFx;
    [FieldOffset(128)] public float @theGe;
}

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

[SerializedExtent(79)]
[XdbName("SkyObject")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SkyObject
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public float @fadeDistanceEnd;
    [FieldOffset(72)] public float @fadeDistanceStart;
    [FieldOffset(76)] public bool @useSceneFog;
    [FieldOffset(77)] public bool @useSkySphereRadius;
    [FieldOffset(78)] public bool @useSoftClipping;
}

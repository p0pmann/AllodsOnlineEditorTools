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

[StructSize(80)]
[XdbName("SkyMesh")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SkyMesh
{
    [FieldOffset(36)] public float @noiseFactor;
    [FieldOffset(40, ArrayStride = 208)] public Layouts.@s_cca220[] @parts;
    [FieldOffset(72)] public float @shift;
    [FieldOffset(76)] public float @yaw;
}

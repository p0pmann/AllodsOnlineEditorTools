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

[StructSize(208)]
[XdbName("AnimatedParameters")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AnimatedParameters
{
    [FieldOffset(40, ArrayStride = 4)] public float[] @cameraFOV;
    [FieldOffset(72, ArrayStride = 12)] public Vector3[] @cameraRotation;
    [FieldOffset(104, ArrayStride = 12)] public Vector3[] @cameraTranslate;
    [FieldOffset(136, ArrayStride = 12)] public Vector3[] @diffuseAdd;
    [FieldOffset(168, ArrayStride = 12)] public Vector3[] @diffuseMul;
    [FieldOffset(200)] public float @fps;
}

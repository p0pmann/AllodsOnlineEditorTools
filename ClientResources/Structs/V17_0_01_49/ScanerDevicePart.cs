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

[SerializedExtent(256)]
[XdbName("ScanerDevicePart")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScanerDevicePart
{
    [FieldOffset(48, ArrayStride = 32)] public Layouts.@s_19ae3b0[] @globalBones;
    [FieldOffset(80)] public Layouts.@s_19ae430 @hub;
    [FieldOffset(104)] public string @locatorName;
    [FieldOffset(128)] public Layouts.@s_19ae430 @ourHub;
    [FieldOffset(152, ArrayStride = 32)] public Layouts.@s_19ae3b0[] @pitchBones;
    [FieldOffset(184, ArrayStride = 32)] public Layouts.@s_19ae3b0[] @rollBones;
    [FieldOffset(216)] public float @sphereRadius;
    [FieldOffset(220)] public float @stripeTextureSize;
    [FieldOffset(224, ArrayStride = 32)] public Layouts.@s_19ae3b0[] @yawBones;
}

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

[SerializedExtent(92)]
[XdbName("TimeTransparencyComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TimeTransparencyComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public float @durationFrom;
    [FieldOffset(72)] public float @durationTo;
    [FieldOffset(76)] public float @fadeAlpha;
    [FieldOffset(80)] public float @fadeTime;
    [FieldOffset(84)] public float @timeStartFrom;
    [FieldOffset(88)] public float @timeStartTo;
}

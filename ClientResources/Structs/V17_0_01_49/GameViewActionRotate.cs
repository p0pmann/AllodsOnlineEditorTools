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

[SerializedExtent(200)]
[XdbName("GameViewActionRotate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionRotate
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(156)] public float @pitch;
    [FieldOffset(160, ArrayStride = 24)] public string[] @targetID;
    [FieldOffset(192)] public float @time;
    [FieldOffset(196)] public float @yaw;
}

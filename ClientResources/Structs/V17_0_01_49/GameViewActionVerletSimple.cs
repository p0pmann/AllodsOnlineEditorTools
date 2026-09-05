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

[SerializedExtent(268)]
[XdbName("GameViewActionVerletSimple")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionVerletSimple
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @creature;
    [FieldOffset(184, ArrayStride = 40)] public Layouts.@s_17c6000[] @cylinders;
    [FieldOffset(216)] public Layouts.@s_17c1e90 @forces;
    [FieldOffset(224)] public Layouts.@s_17c1ee0 @simulation;
    [FieldOffset(244)] public Layouts.@s_17c60b0 @surface;
}

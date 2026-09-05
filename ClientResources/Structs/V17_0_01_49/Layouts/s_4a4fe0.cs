// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(60)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_4a4fe0
{
    [FieldOffset(4)] public int @fpsAdaptiveLODThreshold;
    [FieldOffset(8)] public int @fpsAdaptiveLODTimeout;
    [FieldOffset(16, ArrayStride = 4)] public int[] @fpsRangesMs;
    [FieldOffset(48)] public int @rangeDownTimeoutMs;
    [FieldOffset(52)] public int @rangeUpTimeoutMs;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_4a51b0))] public int @type;
}

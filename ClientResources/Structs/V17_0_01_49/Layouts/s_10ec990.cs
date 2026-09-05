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

[SerializedExtent(37)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_10ec990
{
    [FieldOffset(4)] public float @health;
    [FieldOffset(8)] public float @healthDelta;
    [FieldOffset(12)] public int @healthLevelDelta;
    [FieldOffset(16)] public int @prepareDuration;
    [FieldOffset(20)] public int @prepareDurationDelta;
    [FieldOffset(24)] public float @regen;
    [FieldOffset(28)] public float @speed;
    [FieldOffset(32)] public float @speedDelta;
    [FieldOffset(36)] public bool @ignoreWater;
}

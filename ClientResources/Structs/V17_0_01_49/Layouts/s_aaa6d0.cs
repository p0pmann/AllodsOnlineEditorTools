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

[SerializedExtent(328)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_aaa6d0
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_a78fb0))] public int @ambientSoundImpact;
    [FieldOffset(8)] public float @fadeInSeconds;
    [FieldOffset(12)] public float @fadeOutSeconds;
    [FieldOffset(16)] public Layouts.@s_aaa440 @light;
    [FieldOffset(296)] public float @maxDuration;
    [FieldOffset(300)] public float @maxStartTime;
    [FieldOffset(304)] public float @minDuration;
    [FieldOffset(308)] public float @minStartTime;
    [FieldOffset(312)] public float @probability;
    [FieldOffset(320)] public ResourcePointer @weatherType;
}

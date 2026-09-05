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

[SerializedExtent(216)]
[XdbName("ZoneInfo")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ZoneInfo
{
    [FieldOffset(36)] public bool @isInternal;
    [FieldOffset(48)] public Layouts.@s_a96bc0 @ambience;
    [FieldOffset(88, ArrayStride = 24)] public Layouts.@s_a97800[] @ambienceParameters;
    [FieldOffset(120)] public int @ambienceTimeout;
    [FieldOffset(124)] public float @hiCutFreq;
    [FieldOffset(128)] public ResourcePointer @lights;
    [FieldOffset(136)] public Layouts.@s_a96bc0 @music;
    [FieldOffset(176)] public Layouts.@s_a96bc0 @reverbPreset;
}

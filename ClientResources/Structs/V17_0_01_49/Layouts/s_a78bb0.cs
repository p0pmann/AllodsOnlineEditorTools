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

[SerializedExtent(168)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_a78bb0
{
    [FieldOffset(8)] public Layouts.@s_a96bc0 @ambience;
    [FieldOffset(48, ArrayStride = 24)] public Layouts.@s_a97800[] @ambienceParameters;
    [FieldOffset(80)] public int @ambienceTimeout;
    [FieldOffset(84)] public float @hiCutFreq;
    [FieldOffset(88)] public Layouts.@s_a96bc0 @music;
    [FieldOffset(128)] public Layouts.@s_a96bc0 @reverbPreset;
}

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

[StructSize(264)]
[XdbName("SoundRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SoundRoot
{
    [FieldOffset(40)] public Layouts.@s_a96bc0 @defaultReverbPreset;
    [FieldOffset(80)] public int @reverbInterpolationInterval;
    [FieldOffset(88)] public ResourcePointer @underwaterGlobalParameter;
    [FieldOffset(96)] public float @underwaterHiCutFreq;
    [FieldOffset(104)] public Layouts.@s_a96bc0 @underwaterReverbPreset;
    [FieldOffset(144)] public Layouts.@s_a96bc0 @underwaterSound;
    [FieldOffset(184)] public Layouts.@s_a96d80 @waterEnterSound;
    [FieldOffset(224)] public Layouts.@s_a96d80 @waterLeaveSound;
}

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

[SerializedExtent(114)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_bd7860
{
    [FieldOffset(8, ArrayStride = 40)] public Layouts.@s_bd5240[] @keySounds;
    [FieldOffset(40, ArrayStride = 40)] public Layouts.@s_bd5120[] @objects;
    [FieldOffset(72)] public Layouts.@s_a96d80 @sound;
    [FieldOffset(112)] public bool @allowMultipleSoundInstances;
    [FieldOffset(113)] public bool @playSoundOnKeys;
}

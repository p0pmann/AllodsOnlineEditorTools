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

[SerializedExtent(50)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_caeb80
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(8)] public Layouts.@s_a96d80 @sound;
    [FieldOffset(48)] public bool @noRepeatSoundOnAnimationLoop;
    [FieldOffset(49)] public bool @replaceOriginalSound;
}

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

[StructSize(104)]
[XdbName("CharacterSoundVariation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterSoundVariation
{
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_caec90[] @aliasSounds;
    [FieldOffset(72, ArrayStride = 56)] public Layouts.@s_caeb80[] @animationSounds;
}

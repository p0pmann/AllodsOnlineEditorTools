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

[StructSize(400)]
[XdbName("VisualMob")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualMob
{
    [FieldOffset(36)] public int @charExtScaleIndex;
    [FieldOffset(40)] public ResourcePointer @character;
    [FieldOffset(48)] public Layouts.@s_c4e550 @colorCoefficients;
    [FieldOffset(72)] public Layouts.@s_cc4db0 @creatureParameters;
    [FieldOffset(80)] public float @decalScale;
    [FieldOffset(84)][EnumRef(typeof(Enums.@e_168610))] public int @fixedIdleAnimation;
    [FieldOffset(88)] public int @hitAnimationCooldown;
    [FieldOffset(92)] public int @hitCritAnimationCooldown;
    [FieldOffset(96, ArrayStride = 24)] public Layouts.@s_c8d420[] @items;
    [FieldOffset(128)] public ResourcePointer @mobAnimations;
    [FieldOffset(136)] public ResourcePointer @mobEventsScripts;
    [FieldOffset(144)] public NullablePointer @mobExtension;
    [FieldOffset(152)] public Layouts.@s_1828d0 @pickAabb;
    [FieldOffset(176)] public float @procedureFxScale;
    [FieldOffset(180)] public float @scale;
    [FieldOffset(184)] public ResourcePointer @sfxArmorSet;
    [FieldOffset(192)] public ResourcePointer @soundVariation;
    [FieldOffset(200)] public int @timeToCorpseFadingMax;
    [FieldOffset(204)] public int @timeToCorpseFadingMin;
    [FieldOffset(208)] public float @transparency;
    [FieldOffset(216)] public Layouts.@s_cb1ca0 @variation;
    [FieldOffset(352)] public NullablePointer @visualScript;
    [FieldOffset(360, ArrayStride = 8)] public ResourcePointer[] @visualStates;
    [FieldOffset(392)] public bool @disableFall;
    [FieldOffset(393)] public bool @skipCharacterVisualScript;
    [FieldOffset(394)] public bool @useIdleSpecial;
    [FieldOffset(395)] public bool @useVisualTweaks;
}

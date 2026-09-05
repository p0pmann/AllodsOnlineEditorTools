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

[StructSize(832)]
[XdbName("VisCharacterTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisCharacterTemplate
{
    [FieldOffset(40, ArrayStride = 80)] public Layouts.@s_cbd110[] @additionalPortraitSettings;
    [FieldOffset(72)] public Layouts.@s_a96d80 @agroSound;
    [FieldOffset(112)] public ResourcePointer @animationKeysAction;
    [FieldOffset(120)] public ResourcePointer @animationKeysActionPeriod;
    [FieldOffset(128)] public ResourcePointer @animationKeysSound;
    [FieldOffset(136)] public ResourcePointer @animationProperties;
    [FieldOffset(144)] public ResourcePointer @characterVisObject;
    [FieldOffset(152)] public Layouts.@s_cc4db0 @creatureParameters;
    [FieldOffset(160)] public ResourcePointer @defaultDress;
    [FieldOffset(168)] public ResourcePointer @defaultSoundVariation;
    [FieldOffset(176)] public ResourcePointer @extension;
    [FieldOffset(184)][EnumRef(typeof(Enums.@e_cb59e0))] public int @gender;
    [FieldOffset(192, ArrayStride = 24)] public string[] @hairColoredGeosets;
    [FieldOffset(224)] public float @height;
    [FieldOffset(232)] public string @helmGeoset;
    [FieldOffset(256)] public int @hitAnimationCooldown;
    [FieldOffset(260)] public int @hitCritAnimationCooldown;
    [FieldOffset(264)] public ResourcePointer @hitCriticalEffects;
    [FieldOffset(272)] public ResourcePointer @hitEffects;
    [FieldOffset(280)] public ResourcePointer @lower;
    [FieldOffset(288)] public ResourcePointer @mainBakedTexture;
    [FieldOffset(296)] public ResourcePointer @mainHand;
    [FieldOffset(304)] public float @massCoefficient;
    [FieldOffset(312)] public NullablePointer @meleeAttack;
    [FieldOffset(320)] public ResourcePointer @mobAnimations;
    [FieldOffset(328)] public ResourcePointer @morphSettings;
    [FieldOffset(336)] public Layouts.@s_a96d80 @moveSFX;
    [FieldOffset(376)] public ResourcePointer @offHand;
    [FieldOffset(384)] public Layouts.@s_cba810 @portraitSettings;
    [FieldOffset(432)] public Layouts.@s_a96d80 @preAggroSound;
    [FieldOffset(472)] public float @radius;
    [FieldOffset(480)] public ResourcePointer @sfxArmorSet;
    [FieldOffset(488, ArrayStride = 80)] public Layouts.@s_cbd320[] @specialControllers;
    [FieldOffset(520, ArrayStride = 32)] public Layouts.@s_ca4780[] @specialHairTexPatch;
    [FieldOffset(552)] public ResourcePointer @traceProperties;
    [FieldOffset(560)] public Layouts.@s_cbbbf0 @uiSceneSettings;
    [FieldOffset(600)] public float @uiSelectionScale;
    [FieldOffset(608)] public ResourcePointer @underwear;
    [FieldOffset(616)] public ResourcePointer @upper;
    [FieldOffset(624)] public ResourcePointer @variations;
    [FieldOffset(632)] public Layouts.@s_c81740 @visualAliases;
    [FieldOffset(776)] public NullablePointer @visualScript;
    [FieldOffset(784)] public Layouts.@s_a96d80 @weaponSound;
    [FieldOffset(824)] public bool @disableCorpseThrowing;
    [FieldOffset(825)] public bool @isBreathe;
    [FieldOffset(826)] public bool @showDecal;
    [FieldOffset(827)] public bool @useMobAnimationsSet;
    [FieldOffset(828)] public bool @useWeaponItemsAnimations;
}

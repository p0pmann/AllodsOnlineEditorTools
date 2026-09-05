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

[StructSize(712)]
[XdbName("SlonRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SlonRoot
{
    [FieldOffset(40)] public ResourcePointer @abordageBubbleTemplate;
    [FieldOffset(48)] public ResourcePointer @astralTransitionFog;
    [FieldOffset(56)] public ResourcePointer @astralTransitionFogEnd;
    [FieldOffset(64)] public ResourcePointer @astralTransitionFogStart;
    [FieldOffset(72)] public ResourcePointer @avatarVisObj;
    [FieldOffset(80)] public ResourcePointer @avatarVisualScript;
    [FieldOffset(88)] public ResourcePointer @blockParryFx;
    [FieldOffset(96)] public int @blockParryFxForestall;
    [FieldOffset(104)] public Layouts.@s_196cc70 @cameras;
    [FieldOffset(144)] public ResourcePointer @coldBreathFx;
    [FieldOffset(152)] public ResourcePointer @constants;
    [FieldOffset(160)] public ResourcePointer @creatureVisObj;
    [FieldOffset(168)] public ResourcePointer @creatureVisualScript;
    [FieldOffset(176)] public ResourcePointer @defaultGuildVisualSettings;
    [FieldOffset(184)] public ResourcePointer @deviceVisObj;
    [FieldOffset(192)] public float @enemyAvatarCritCooldown;
    [FieldOffset(196)] public float @enemyAvatarHitCooldown;
    [FieldOffset(200)] public ResourcePointer @fairyLevelChangedScript;
    [FieldOffset(208, ArrayStride = 40)] public Layouts.@s_196ce10[] @fatalities;
    [FieldOffset(240)] public string @fatalityFlagCasterName;
    [FieldOffset(264)] public string @fatalityFlagVictimName;
    [FieldOffset(288)] public ResourcePointer @guildRoot;
    [FieldOffset(296)] public ResourcePointer @haloTable;
    [FieldOffset(304)] public ResourcePointer @hideCloakSpell;
    [FieldOffset(312)] public ResourcePointer @hideHelmSpell;
    [FieldOffset(320)] public ResourcePointer @leftArmController;
    [FieldOffset(328)] public ResourcePointer @levelChangedScript;
    [FieldOffset(336)] public NullablePointer @lootEndAction;
    [FieldOffset(344)] public NullablePointer @lootStartAction;
    [FieldOffset(352)] public float @mainAvatarCritCooldown;
    [FieldOffset(356)] public float @mainAvatarHitCooldown;
    [FieldOffset(360)] public float @minSelectionBox;
    [FieldOffset(368)] public ResourcePointer @mobVisualScript;
    [FieldOffset(376)] public ResourcePointer @musicSettings;
    [FieldOffset(384)] public NullablePointer @newWeaponDressed;
    [FieldOffset(392)] public ResourcePointer @parrySounds;
    [FieldOffset(400)] public Layouts.@s_a718e0 @portraitManagerLight;
    [FieldOffset(536)] public ResourcePointer @poweredLSWeaponsRoot;
    [FieldOffset(544)] public ResourcePointer @priorityOrders;
    [FieldOffset(552)] public ResourcePointer @projectileVisObj;
    [FieldOffset(560)] public ResourcePointer @propertiesOfCreatureAnimations;
    [FieldOffset(568)] public ResourcePointer @rightArmController;
    [FieldOffset(576)] public ResourcePointer @shadowTexture;
    [FieldOffset(584)] public ResourcePointer @shipCollisionFX;
    [FieldOffset(592)] public ResourcePointer @soundRoot;
    [FieldOffset(600)] public ResourcePointer @spellResistFx;
    [FieldOffset(608)] public int @spellResistFxForestall;
    [FieldOffset(616, ArrayStride = 40)] public Layouts.@s_196cef0[] @stubAnimations;
    [FieldOffset(648)] public ResourcePointer @unarmedWeaponItemClass;
    [FieldOffset(656)] public ResourcePointer @underWaterRays;
    [FieldOffset(664)] public ResourcePointer @visCharTemplates;
    [FieldOffset(672)] public ResourcePointer @visualSettings;
    [FieldOffset(680)] public ResourcePointer @wallCollision;
    [FieldOffset(688)] public ResourcePointer @wallFX;
    [FieldOffset(696)] public ResourcePointer @warpEffectSpell;
    [FieldOffset(704)] public ResourcePointer @waterFootstepMaterial;
}

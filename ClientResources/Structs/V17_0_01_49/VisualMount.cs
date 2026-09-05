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

[StructSize(208)]
[XdbName("VisualMount")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualMount
{
    [FieldOffset(36)] public float @additionalStableAngle;
    [FieldOffset(40)] public Layouts.@s_a96d80 @additionalWhoosh;
    [FieldOffset(80)] public Layouts.@s_c95690 @cameraShift;
    [FieldOffset(96)] public Layouts.@s_a96d80 @hitSoundOverride;
    [FieldOffset(136)] public ResourcePointer @mount;
    [FieldOffset(144)] public ResourcePointer @mountForStable;
    [FieldOffset(152)] public float @mountSize;
    [FieldOffset(160, ArrayStride = 24)] public Layouts.@s_c95700[] @scales;
    [FieldOffset(192)] public ResourcePointer @visualMountClass;
    [FieldOffset(200)] public bool @transferWeaponFromAvatarEnable;
    [FieldOffset(201)] public bool @useCharacterMorphHeightScale;
}

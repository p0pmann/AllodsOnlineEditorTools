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

[SerializedExtent(290)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1abe120
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_a78fb0))] public int @ambientSoundImpact;
    [FieldOffset(8)] public ResourcePointer @areaEffect;
    [FieldOffset(16)] public Layouts.@s_a9c330 @colorGradingSettings;
    [FieldOffset(32)] public float @fadeTime;
    [FieldOffset(40)] public Layouts.@s_a718e0 @light;
    [FieldOffset(176)] public ResourcePointer @postEffectParams;
    [FieldOffset(184)] public Layouts.@s_a9d4a0 @posteffectFogSettings;
    [FieldOffset(268)][EnumRef(typeof(Enums.@e_1abdd20))] public int @priority;
    [FieldOffset(272)] public ResourcePointer @skyMesh;
    [FieldOffset(280)] public ResourcePointer @weatherType;
    [FieldOffset(288)] public bool @hasLight;
    [FieldOffset(289)] public bool @playInBuildings;
}

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

[SerializedExtent(451)]
[XdbName("EffectMaterialParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EffectMaterialParams
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_ac4390))] public int @blendEffect;
    [FieldOffset(48)] public int @color;
    [FieldOffset(52)] public Layouts.@s_ac3d80 @colorGrading;
    [FieldOffset(64)] public Layouts.@s_ac3f10 @colorGradingTexture;
    [FieldOffset(120)] public Layouts.@s_ac3f10 @diffuseTexture;
    [FieldOffset(176)] public Layouts.@s_ac4100 @maskEffect;
    [FieldOffset(216)] public Layouts.@s_ac3f10 @maskTexture;
    [FieldOffset(272)] public Layouts.@s_17f0c0 @textureAtlasParameters;
    [FieldOffset(312)] public float @transparency;
    [FieldOffset(316)] public Layouts.@s_ac42b0 @uvDistortionEffectBA;
    [FieldOffset(344)] public Layouts.@s_ac42b0 @uvDistortionEffectRG;
    [FieldOffset(376)] public Layouts.@s_ac3f10 @uvDistortionTexture;
    [FieldOffset(432)] public float @vertexColorAlphaContribution;
    [FieldOffset(436)] public float @viewDirectionFade;
    [FieldOffset(440)] public float @virtualOffset;
    [FieldOffset(444)] public bool @fullRangeDistortion;
    [FieldOffset(445)] public bool @selfillum;
    [FieldOffset(446)] public bool @transparent;
    [FieldOffset(447)] public bool @useDepthSortedTransparency;
    [FieldOffset(448)] public bool @useFog;
    [FieldOffset(449)] public bool @useRandomTextureOffset;
    [FieldOffset(450)] public bool @visible;
}

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

[SerializedExtent(276)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_aaa440
{
    [FieldOffset(8)] public ResourcePointer @areaEffect;
    [FieldOffset(16)] public Layouts.@s_a9c330 @colorGradingSettings;
    [FieldOffset(32)] public Layouts.@s_a718e0 @light;
    [FieldOffset(168)] public ResourcePointer @postEffectParams;
    [FieldOffset(176)] public Layouts.@s_a9d4a0 @posteffectFogSettings;
    [FieldOffset(264)] public ResourcePointer @skyMesh;
    [FieldOffset(272)] public float @time;
}

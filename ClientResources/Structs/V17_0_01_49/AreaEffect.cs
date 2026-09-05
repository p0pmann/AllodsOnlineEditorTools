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

[StructSize(72)]
[XdbName("AreaEffect")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AreaEffect
{
    [FieldOffset(36)] public int @areaEffectGridStep;
    [FieldOffset(40)] public ResourcePointer @astralParams;
    [FieldOffset(48)] public ResourcePointer @effect;
    [FieldOffset(56)] public float @fadeFactor;
    [FieldOffset(60)] public float @maxEffectSpeed;
    [FieldOffset(64)] public bool @disableAstralFX;
    [FieldOffset(65)] public bool @randomRotate;
}

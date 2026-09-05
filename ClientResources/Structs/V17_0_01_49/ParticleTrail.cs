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

[StructSize(200)]
[XdbName("ParticleTrail")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ParticleTrail
{
    [FieldOffset(36)] public float @ambientFactor;
    [FieldOffset(40)] public ResourcePointer @curvesTexture;
    [FieldOffset(48)] public Layouts.@s_acbb80 @cutout;
    [FieldOffset(88)] public Layouts.@s_acbd60 @diffuse;
    [FieldOffset(112)] public Layouts.@s_acbf60 @distortion;
    [FieldOffset(160)] public float @fadeEnd;
    [FieldOffset(164)] public float @fadeStart;
    [FieldOffset(168)] public float @fogFactor;
    [FieldOffset(172)] public float @lifetime;
    [FieldOffset(176)][EnumRef(typeof(Enums.@e_acc330))] public int @orientation;
    [FieldOffset(180)][EnumRef(typeof(Enums.@e_acc5c0))] public int @spawnMode;
    [FieldOffset(184)] public float @spawnRate;
    [FieldOffset(188)] public float @width;
    [FieldOffset(192)] public float @widthChangeSpeed;
}

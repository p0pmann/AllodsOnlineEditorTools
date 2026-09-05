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

[StructSize(584)]
[XdbName("mapLoader.MapResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MapResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public float @foliageDistance;
    [FieldOffset(80)] public Layouts.@s_a6f310 @instabilityZoneInfo;
    [FieldOffset(216)] public string @internalName;
    [FieldOffset(240)] public float @loadDistance;
    [FieldOffset(248)] public ResourcePointer @mapTemplate;
    [FieldOffset(256)] public Layouts.@s_a718e0 @minimapLight;
    [FieldOffset(392)] public TextFileRef @name;
    [FieldOffset(424)] public float @predictionElastic;
    [FieldOffset(432)] public Layouts.@s_a6f310 @stabilityZoneInfo;
    [FieldOffset(568)] public ResourcePointer @textureItem;
    [FieldOffset(576)] public bool @anonymized;
    [FieldOffset(577)] public bool @terrainUsesQualitySettings;
}

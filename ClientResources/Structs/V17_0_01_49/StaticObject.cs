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

[StructSize(272)]
[XdbName("mapLoader.StaticObject")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StaticObject
{
    [FieldOffset(40)] public ResourcePointer @Collision;
    [FieldOffset(48)] public ResourcePointer @ObjectTemplate;
    [FieldOffset(56)] public Layouts.@s_a96bc0 @ambienceSound;
    [FieldOffset(96, ArrayStride = 8)] public ResourcePointer[] @areaMiniMaps;
    [FieldOffset(128)] public Layouts.@s_a96bc0 @music;
    [FieldOffset(168, ArrayStride = 80)] public Layouts.@s_aa3280[] @parts;
    [FieldOffset(200, ArrayStride = 64)] public Layouts.@s_aa3430[] @serverLocators;
    [FieldOffset(232, ArrayStride = 4)] public int[] @visibleZoneIndices;
    [FieldOffset(264)] public bool @coloredObject;
}

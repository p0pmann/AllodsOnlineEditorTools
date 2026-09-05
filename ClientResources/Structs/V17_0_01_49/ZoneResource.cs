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

[StructSize(216)]
[XdbName("gameMechanics.map.zone.ZoneResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ZoneResource
{
    [FieldOffset(40, ArrayStride = 24)] public string[] @attributes;
    [FieldOffset(72)] public int @color;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public string @internalName;
    [FieldOffset(136)] public TextFileRef @name;
    [FieldOffset(168)] public ResourcePointer @zoneLights;
    [FieldOffset(176)] public bool @hideZoneAnnounce;
    [FieldOffset(177)] public bool @useColdBreath;
    [FieldOffset(188)] public Layouts.@s_163010 @graveyards;
    [FieldOffset(192)] public ResourcePointer @parentZone;
    [FieldOffset(200)] public ResourcePointer @pvpType;
    [FieldOffset(208)] public Layouts.@s_163010 @sanctuaries;
}

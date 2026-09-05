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

[SerializedExtent(354)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_155d4a0
{
    [FieldOffset(48)] public Layouts.@s_151d4a0 @contextActionInfo;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @interruptsActionGroups;
    [FieldOffset(208)] public TextFileRef @description;
    [FieldOffset(240)] public int @forageSkillCheckMin;
    [FieldOffset(248)] public ResourcePointer @image;
    [FieldOffset(256)] public TextFileRef @name;
    [FieldOffset(288)] public ResourcePointer @rerollCurrency;
    [FieldOffset(296)] public int @scorePerCharacterLevel;
    [FieldOffset(300)] public int @skillScoreLevelCap;
    [FieldOffset(304)] public ResourcePointer @skillSlot;
    [FieldOffset(312)] public string @sysName;
    [FieldOffset(336)][EnumRef(typeof(Enums.@e_15fb910))] public int @type;
    [FieldOffset(344)] public long @zoneCooldown;
    [FieldOffset(352)] public bool @hide;
    [FieldOffset(353)] public bool @useLevels;
}

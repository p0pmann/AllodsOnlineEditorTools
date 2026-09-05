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

[SerializedExtent(128)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1574b00
{
    [FieldOffset(4)] public float @armorMod;
    [FieldOffset(8)] public float @astralMod;
    [FieldOffset(12)] public float @defenceMod;
    [FieldOffset(16)] public float @elementalMod;
    [FieldOffset(24, ArrayStride = 4)][EnumRef(typeof(Enums.@e_1040220))] public int[] @enchants;
    [FieldOffset(56)] public float @goldMod;
    [FieldOffset(64, ArrayStride = 24)] public Layouts.@s_1574040[] @locks;
    [FieldOffset(96)] public int @minLevelAvail;
    [FieldOffset(100)] public float @natureMod;
    [FieldOffset(104)] public float @offenceMod;
    [FieldOffset(108)] public float @powerMod;
    [FieldOffset(112)] public ResourcePointer @quality;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @slot;
    [FieldOffset(124)] public float @staminaMod;
}

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

[SerializedExtent(104)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_196a590
{
    [FieldOffset(4)] public int @avatarTimeToCorpseFadingMax;
    [FieldOffset(8)] public int @avatarTimeToCorpseFadingMin;
    [FieldOffset(12)] public Layouts.@s_c5e240 @defKillingVisualParams;
    [FieldOffset(24)] public float @distanceMax;
    [FieldOffset(28)] public float @distanceMin;
    [FieldOffset(32)] public float @friction;
    [FieldOffset(36)] public float @horSpeedMax;
    [FieldOffset(40)] public float @horSpeedMin;
    [FieldOffset(48, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @lootBagAnimations;
    [FieldOffset(80)] public ResourcePointer @lootBagVisObject;
    [FieldOffset(88)] public int @timeToCorpseFadingMax;
    [FieldOffset(92)] public int @timeToCorpseFadingMin;
    [FieldOffset(96)] public float @zMax;
    [FieldOffset(100)] public float @zMin;
}

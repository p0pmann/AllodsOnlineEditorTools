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

[StructSize(328)]
[XdbName("WeaponHoldingRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WeaponHoldingRoot
{
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponAny;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponBoast;
    [FieldOffset(104, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponByState;
    [FieldOffset(136, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponCast;
    [FieldOffset(168, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponChargedWand;
    [FieldOffset(200, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponMelee;
    [FieldOffset(232, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponNone;
    [FieldOffset(264, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponRanged;
    [FieldOffset(296, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @weaponWand;
}

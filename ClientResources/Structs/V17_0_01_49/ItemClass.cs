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

[StructSize(264)]
[XdbName("gameMechanics.constructor.schemes.item.ItemClass")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemClass
{
    [FieldOffset(40)] public NullablePointer @armorMod;
    [FieldOffset(48)] public Layouts.@s_1597ca0 @damageInfo;
    [FieldOffset(64)] public int @minLevelAvail;
    [FieldOffset(72)] public TextFileRef @name;
    [FieldOffset(104)] public Layouts.@s_10469a0 @proficiency;
    [FieldOffset(184, ArrayStride = 16)] public Layouts.@s_1597d20[] @relicViewReplacements;
    [FieldOffset(216)] public float @spellPowerDelta;
    [FieldOffset(224)] public string @sysName;
    [FieldOffset(248)] public NullablePointer @weaponRangeStats;
    [FieldOffset(256)] public bool @canShieldBlock;
    [FieldOffset(257)] public bool @hideDPS;
    [FieldOffset(258)] public bool @isForAll;
    [FieldOffset(259)] public bool @spellPower;
    [FieldOffset(260)] public bool @summandDPS;
}

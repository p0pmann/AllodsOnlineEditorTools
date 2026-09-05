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

[StructSize(120)]
[XdbName("gameMechanics.world.mob.MobKind")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MobKind
{
    [FieldOffset(40)] public NullablePointer @attackRangeStats;
    [FieldOffset(48)] public string @className;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_15b2850))] public int @manaType;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_1563300))] public int @race;
}

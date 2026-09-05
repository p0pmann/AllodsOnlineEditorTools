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

[StructSize(288)]
[XdbName("gameMechanics.world.rules.RuleResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RuleResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public ResourcePointer @faction;
    [FieldOffset(120)] public NullablePointer @level;
    [FieldOffset(128, ArrayStride = 24)] public Layouts.@s_15eb3d0[] @locations;
    [FieldOffset(160)] public TextFileRef @name;
    [FieldOffset(192)] public ResourcePointer @notification;
    [FieldOffset(200)] public int @rating;
    [FieldOffset(208)] public NullablePointer @reward;
    [FieldOffset(216)] public string @sysName;
    [FieldOffset(240, ArrayStride = 4)][EnumRef(typeof(Enums.@e_15eb440))] public int[] @types;
    [FieldOffset(272)] public ResourcePointer @zone;
    [FieldOffset(280)] public bool @alwaysHide;
    [FieldOffset(281)] public bool @hideInactive;
}

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

[StructSize(600)]
[XdbName("gameMechanics.constructor.schemes.mount.MountResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MountResource
{
    [FieldOffset(48)] public Layouts.@s_151d4a0 @contextActionInfo;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @interruptsActionGroups;
    [FieldOffset(208)] public TextFileRef @Name;
    [FieldOffset(240, ArrayStride = 8)] public ResourcePointer[] @abilities;
    [FieldOffset(272)] public ResourcePointer @alternativeSkins;
    [FieldOffset(280)] public ResourcePointer @basicSkin;
    [FieldOffset(288, ArrayStride = 8)] public ResourcePointer[] @contextActions;
    [FieldOffset(320)] public float @corpulence;
    [FieldOffset(328, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(360)] public TextFileRef @description;
    [FieldOffset(392)] public int @grade;
    [FieldOffset(396)] public Layouts.@s_10ec990 @mechanics;
    [FieldOffset(440, ArrayStride = 8)] public ResourcePointer[] @overrideMounts;
    [FieldOffset(472)] public NullablePointer @penaltyCalcer;
    [FieldOffset(480, ArrayStride = 8)] public ResourcePointer[] @spells;
    [FieldOffset(512)] public string @sysName;
    [FieldOffset(536, ArrayStride = 112)] public Layouts.@s_1071f30[] @talentSlots;
    [FieldOffset(568)] public Layouts.@s_122d150 @timeLeft;
    [FieldOffset(592)] public bool @canBeMorphed;
    [FieldOffset(593)] public bool @isExoMount;
    [FieldOffset(594)] public bool @isProbe;
}

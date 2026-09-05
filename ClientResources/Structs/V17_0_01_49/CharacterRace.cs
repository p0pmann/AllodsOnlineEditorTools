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

[StructSize(176)]
[XdbName("gameMechanics.world.avatar.CharacterRace")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterRace
{
    [FieldOffset(36)] public int @changeRaceMinLevel;
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @changeRaceUnlocks;
    [FieldOffset(72)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112, ArrayStride = 48)] public Layouts.@s_154d5a0[] @raceSexDescs;
    [FieldOffset(144)] public string @sysName;
    [FieldOffset(168)] public bool @allowToCreateFirstling;
    [FieldOffset(169)] public bool @allowToCreateResetRemort;
}

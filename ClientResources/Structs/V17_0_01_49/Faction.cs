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

[StructSize(144)]
[XdbName("gameMechanics.world.creature.Faction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Faction
{
    [FieldOffset(44)] public int @defaultReputation;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @friends;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public string @sysName;
    [FieldOffset(136)] public bool @hide;
    [FieldOffset(137)] public bool @hideNotification;
    [FieldOffset(138)] public bool @littleOldMan;
}

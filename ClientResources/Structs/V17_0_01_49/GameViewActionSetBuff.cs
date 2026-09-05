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

[SerializedExtent(240)]
[XdbName("GameViewActionSetBuff")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionSetBuff
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @offenderCreature;
    [FieldOffset(184)] public ResourcePointer @producer;
    [FieldOffset(192)] public string @targetCreature;
    [FieldOffset(224)] public ResourcePointer @buff;
    [FieldOffset(232)] public int @stackCount;
    [FieldOffset(236)] public int @time;
}

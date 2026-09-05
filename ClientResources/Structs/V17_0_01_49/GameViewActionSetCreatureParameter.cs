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
[XdbName("GameViewActionSetCreatureParameter")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionSetCreatureParameter
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @offenderCreature;
    [FieldOffset(184)] public ResourcePointer @producer;
    [FieldOffset(192)] public string @targetCreature;
    [FieldOffset(224)] public NullablePointer @parameter;
    [FieldOffset(232)][EnumRef(typeof(Enums.@e_17baac0))] public int @useValueFor;
    [FieldOffset(236)] public float @value;
}

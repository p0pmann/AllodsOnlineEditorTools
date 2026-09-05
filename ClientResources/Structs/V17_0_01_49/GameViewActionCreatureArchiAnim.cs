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

[SerializedExtent(204)]
[XdbName("GameViewActionCreatureArchiAnim")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCreatureArchiAnim
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(156)][EnumRef(typeof(Enums.@e_168610))] public int @assaulter;
    [FieldOffset(160)][EnumRef(typeof(Enums.@e_168610))] public int @caster;
    [FieldOffset(168)] public string @creature;
    [FieldOffset(192)][EnumRef(typeof(Enums.@e_168610))] public int @defender;
    [FieldOffset(196)][EnumRef(typeof(Enums.@e_168610))] public int @group;
    [FieldOffset(200)] public int @loopTime;
}

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

[SerializedExtent(248)]
[XdbName("GameViewActionCreatureIterateViews")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCreatureIterateViews
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @iteratorID;
    [FieldOffset(184)] public int @pauseAfterMsec;
    [FieldOffset(188)] public int @pauseBeforeMsec;
    [FieldOffset(192)] public bool @clearInfoBeforeItem;
    [FieldOffset(193)] public bool @clearInfoBeforeStart;
    [FieldOffset(194)] public bool @pauseAfterFirst;
    [FieldOffset(208)] public string @creature;
    [FieldOffset(232)] public ResourcePointer @gameViewScript;
    [FieldOffset(240)] public ResourcePointer @iterationsList;
}

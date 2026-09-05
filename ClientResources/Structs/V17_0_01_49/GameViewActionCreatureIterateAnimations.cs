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

[SerializedExtent(272)]
[XdbName("GameViewActionCreatureIterateAnimations")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCreatureIterateAnimations
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @iteratorID;
    [FieldOffset(184)] public int @pauseAfterMsec;
    [FieldOffset(188)] public int @pauseBeforeMsec;
    [FieldOffset(192)] public bool @clearInfoBeforeItem;
    [FieldOffset(193)] public bool @clearInfoBeforeStart;
    [FieldOffset(194)] public bool @pauseAfterFirst;
    [FieldOffset(208)] public string @animationVariableName;
    [FieldOffset(232)] public string @creature;
    [FieldOffset(256)] public ResourcePointer @creatureVisualSript;
    [FieldOffset(264)] public ResourcePointer @testSettings;
}

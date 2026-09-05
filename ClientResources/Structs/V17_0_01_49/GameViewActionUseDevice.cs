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

[SerializedExtent(252)]
[XdbName("GameViewActionUseDevice")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionUseDevice
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @casterCreature;
    [FieldOffset(184)] public Layouts.@s_17c9f00 @interruptParams;
    [FieldOffset(208)] public Layouts.@s_17ca1a0 @precastParams;
    [FieldOffset(224)] public string @targetDevice;
    [FieldOffset(248)] public int @useDuration;
}

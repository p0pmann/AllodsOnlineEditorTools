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

[SerializedExtent(298)]
[XdbName("GameViewActionCameraMove")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCameraMove
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public Layouts.@s_11ba7d0 @emulationParameters;
    [FieldOffset(208)] public Layouts.@s_11a76e0 @creaturePlacement;
    [FieldOffset(240)] public string @followCreature;
    [FieldOffset(264, ArrayStride = 120)] public Layouts.@s_11a2b80[] @moves;
    [FieldOffset(296)] public bool @smoothTrack;
    [FieldOffset(297)] public bool @useTarget;
}

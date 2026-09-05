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

[SerializedExtent(188)]
[XdbName("GameViewActionSetShield")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionSetShield
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(156)] public float @maxValue;
    [FieldOffset(160)] public string @targetID;
    [FieldOffset(184)] public float @value;
}

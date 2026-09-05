// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(41)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_18de9b0
{
    [FieldOffset(4)] public float @delayBefore;
    [FieldOffset(8, ArrayStride = 120)] public Layouts.@s_11a2b80[] @moves;
    [FieldOffset(40)] public bool @smoothTrack;
}

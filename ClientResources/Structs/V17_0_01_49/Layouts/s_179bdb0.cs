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

[SerializedExtent(105)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_179bdb0
{
    [FieldOffset(4)] public int @delayBefore;
    [FieldOffset(8)] public int @repeatAfter;
    [FieldOffset(12)] public int @repeatCount;
    [FieldOffset(16)] public Layouts.@s_17caf40 @report;
    [FieldOffset(104)] public bool @skip;
}

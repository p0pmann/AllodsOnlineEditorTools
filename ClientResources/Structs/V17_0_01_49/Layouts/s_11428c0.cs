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

[SerializedExtent(136)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11428c0
{
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @aspects;
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @commonGoldStats;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @commonSilverStats;
    [FieldOffset(104, ArrayStride = 104)] public Layouts.@s_1142cb0[] @slotsStats;
}

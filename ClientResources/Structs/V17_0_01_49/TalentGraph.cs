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

[StructSize(112)]
[XdbName("gameMechanics.world.avatar.talents.TalentGraph")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TalentGraph
{
    [FieldOffset(40, ArrayStride = 12)] public Layouts.@s_1006a50[] @edges;
    [FieldOffset(72, ArrayStride = 8)] public NullablePointer[] @nodes;
    [FieldOffset(104)] public int @version;
}

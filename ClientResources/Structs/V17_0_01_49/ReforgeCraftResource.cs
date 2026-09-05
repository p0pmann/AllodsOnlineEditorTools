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
[XdbName("gameMechanics.elements.skills.reforge.ReforgeCraftResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ReforgeCraftResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @available;
    [FieldOffset(72, ArrayStride = 120)] public Layouts.@s_10bca10[] @entries;
    [FieldOffset(104)] public int @variationsCount;
}

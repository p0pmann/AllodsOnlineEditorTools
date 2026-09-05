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

[StructSize(224)]
[XdbName("gameMechanics.world.gameRoot.RemortRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RemortRoot
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @createConditions;
    [FieldOffset(72)] public ResourcePointer @createResetAction;
    [FieldOffset(80)] public NullablePointer @predicateShowNPC;
    [FieldOffset(88, ArrayStride = 48)] public Layouts.@s_15e0660[] @remortCreateRaceDescriptors;
    [FieldOffset(120, ArrayStride = 56)] public Layouts.@s_15e07a0[] @remortResetRaceDescriptors;
    [FieldOffset(152, ArrayStride = 8)] public NullablePointer[] @resetConditions;
    [FieldOffset(184)] public ResourcePointer @switchAction;
    [FieldOffset(192, ArrayStride = 8)] public NullablePointer[] @switchConditions;
}

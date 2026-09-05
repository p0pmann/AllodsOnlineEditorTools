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

[SerializedExtent(152)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1606370
{
    [FieldOffset(8, ArrayStride = 8)] public NullablePointer[] @casterConditions;
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @casterResources;
    [FieldOffset(72)] public NullablePointer @channelingMechanics;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @conditions;
    [FieldOffset(112)] public NullablePointer @cooldown;
    [FieldOffset(120, ArrayStride = 8)] public NullablePointer[] @targetConditions;
}

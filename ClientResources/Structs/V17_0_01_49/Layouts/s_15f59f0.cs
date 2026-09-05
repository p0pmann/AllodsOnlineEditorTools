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

[SerializedExtent(80)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_15f59f0
{
    [FieldOffset(8, ArrayStride = 12)] public Layouts.@s_15f5830[] @byLevel;
    [FieldOffset(40, ArrayStride = 16)] public Layouts.@s_15f58a0[] @byType;
    [FieldOffset(72)] public NullablePointer @withCrystals;
}

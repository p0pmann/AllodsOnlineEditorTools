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

[SerializedExtent(104)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_5645a0
{
    [FieldOffset(8, ArrayStride = 24)] public Layouts.@s_5642d0[] @bgReplacements;
    [FieldOffset(40)] public int @bonus;
    [FieldOffset(48)] public ResourcePointer @bonusBackground;
    [FieldOffset(56, ArrayStride = 48)] public Layouts.@s_564400[] @items;
    [FieldOffset(88)] public int @min;
    [FieldOffset(96)] public ResourcePointer @unlock;
}

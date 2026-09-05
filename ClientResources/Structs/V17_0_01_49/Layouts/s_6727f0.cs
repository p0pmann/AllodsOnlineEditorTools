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

[SerializedExtent(88)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_6727f0
{
    [FieldOffset(4)] public int @height;
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @otherQuestZones;
    [FieldOffset(40)] public int @width;
    [FieldOffset(44)] public int @x;
    [FieldOffset(48)] public int @y;
    [FieldOffset(56, ArrayStride = 8)] public ResourcePointer[] @zones;
}

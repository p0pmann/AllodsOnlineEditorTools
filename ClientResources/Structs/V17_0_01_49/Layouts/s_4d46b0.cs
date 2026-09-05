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

[SerializedExtent(176)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_4d46b0
{
    [FieldOffset(4)] public int @count;
    [FieldOffset(8)] public WString @faction;
    [FieldOffset(32)] public WString @map;
    [FieldOffset(56)] public int @maxLevel;
    [FieldOffset(60)] public int @minLevel;
    [FieldOffset(64)] public WString @name;
    [FieldOffset(88, ArrayStride = 12)] public Vector3[] @positions;
    [FieldOffset(120, ArrayStride = 8)] public ResourcePointer[] @questLoot;
    [FieldOffset(152)] public WString @zone;
}

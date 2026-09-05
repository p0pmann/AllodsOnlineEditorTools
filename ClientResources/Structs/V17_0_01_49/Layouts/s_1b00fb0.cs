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

[SerializedExtent(20)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1b00fb0
{
    [FieldOffset(4)] public float @panSpeed;
    [FieldOffset(8)] public float @tlitSpeed;
    [FieldOffset(12)][EnumRef(typeof(Enums.@e_1b010c0))] public int @type;
    [FieldOffset(16)] public float @zoomSpeed;
}

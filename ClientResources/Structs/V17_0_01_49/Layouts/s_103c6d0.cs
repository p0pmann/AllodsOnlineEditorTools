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
public partial class @s_103c6d0
{
    [FieldOffset(4)] public float @power;
    [FieldOffset(8)] public float @secondary;
    [FieldOffset(12)][EnumRef(typeof(Enums.@e_1040220))] public int @slot;
    [FieldOffset(16)] public float @stamina;
}

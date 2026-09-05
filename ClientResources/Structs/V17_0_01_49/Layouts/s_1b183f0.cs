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

[SerializedExtent(44)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1b183f0
{
    [FieldOffset(8)] public string @name;
    [FieldOffset(32)] public ResourcePointer @resource;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_1b18070))] public int @type;
}

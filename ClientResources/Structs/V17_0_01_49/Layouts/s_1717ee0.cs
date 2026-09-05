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

[SerializedExtent(48)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1717ee0
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(8)] public string @locatorName;
    [FieldOffset(32)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(36)] public Vector3 @shift;
}

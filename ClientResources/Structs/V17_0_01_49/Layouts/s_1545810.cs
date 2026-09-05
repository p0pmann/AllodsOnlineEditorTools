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
public partial class @s_1545810
{
    [FieldOffset(8)] public string @locator;
    [FieldOffset(32)][EnumRef(typeof(Enums.@e_1545c10))] public int @runType;
    [FieldOffset(36)] public float @scale;
    [FieldOffset(40)] public ResourcePointer @visObj;
}

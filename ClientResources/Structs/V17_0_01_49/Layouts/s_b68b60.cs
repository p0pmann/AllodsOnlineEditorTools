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

[SerializedExtent(93)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_b68b60
{
    [FieldOffset(4)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(28)] public int @endElement;
    [FieldOffset(32, ArrayStride = 24)] public string[] @implicitAreas;
    [FieldOffset(64)] public string @name;
    [FieldOffset(88)] public int @startElement;
    [FieldOffset(92)] public bool @areaPart;
}

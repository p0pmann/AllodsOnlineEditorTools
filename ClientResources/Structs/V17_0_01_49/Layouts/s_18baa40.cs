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

[SerializedExtent(102)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_18baa40
{
    [FieldOffset(8)] public Layouts.@s_18c2650 @modificationScript;
    [FieldOffset(88)] public Vector2 @size;
    [FieldOffset(96)] public int @zoom;
    [FieldOffset(100)] public bool @allowTransparentBackground;
    [FieldOffset(101)] public bool @noRefreshOnLoading;
}

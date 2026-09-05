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

[SerializedExtent(96)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_949b80
{
    [FieldOffset(8, ArrayStride = 40)] public Layouts.@s_949cc0[] @filters;
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)] public string @weightVar;
}

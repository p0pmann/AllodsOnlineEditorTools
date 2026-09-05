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

[SerializedExtent(80)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_116f190
{
    [FieldOffset(8, ArrayStride = 40)] public Layouts.@s_116e590[] @answers;
    [FieldOffset(40)] public int @answersCount;
    [FieldOffset(48)] public TextFileRef @description;
}

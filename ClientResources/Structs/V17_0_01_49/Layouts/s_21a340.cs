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

[SerializedExtent(192)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_21a340
{
    [FieldOffset(8, ArrayStride = 56)] public Layouts.@s_215800[] @defines;
    [FieldOffset(40)] public string @entry;
    [FieldOffset(64, ArrayStride = 24)] public string[] @profiles;
    [FieldOffset(96, ArrayStride = 4)] public int[] @shaderIndices;
    [FieldOffset(128, ArrayStride = 48)] public Layouts.@s_2154c0[] @shaderStruct;
    [FieldOffset(160, ArrayStride = 48)] public Layouts.@s_2156a0[] @switches;
}

// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49;

[StructSize(104)]
[XdbName("GeometryPreset")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GeometryPreset
{
    [FieldOffset(40)] public ResourcePointer @geometry;
    [FieldOffset(48, ArrayStride = 80)] public Layouts.@s_ac8d40[] @materials;
    [FieldOffset(80)] public string @presetName;
}

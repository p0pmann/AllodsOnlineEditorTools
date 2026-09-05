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

[SerializedExtent(121)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c98930
{
    [FieldOffset(8)] public ResourcePointer @disablingAnimations;
    [FieldOffset(16)] public string @handBone;
    [FieldOffset(40)] public string @handBone01;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(72)] public string @reinsBone;
    [FieldOffset(96)] public string @reinsBone01;
    [FieldOffset(120)] public bool @use;
}

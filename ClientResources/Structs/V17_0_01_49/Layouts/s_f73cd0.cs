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

[SerializedExtent(104)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_f73cd0
{
    [FieldOffset(8, ArrayStride = 80)] public Layouts.@s_f74bb0[] @animationsReplacements;
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5d710))] public int[] @members;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_f726b0))] public int[] @targets;
}

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

[SerializedExtent(44)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c7c880
{
    [FieldOffset(8, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
}

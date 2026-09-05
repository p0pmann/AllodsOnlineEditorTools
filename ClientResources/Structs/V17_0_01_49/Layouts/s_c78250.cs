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
public partial class @s_c78250
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_168610))] public int @groupAnimation;
    [FieldOffset(12)] public int @maxDelayTime;
    [FieldOffset(16, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @memberAnimations;
}

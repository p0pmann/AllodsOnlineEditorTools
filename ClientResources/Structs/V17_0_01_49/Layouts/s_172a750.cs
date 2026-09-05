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

[SerializedExtent(73)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_172a750
{
    [FieldOffset(8, ArrayStride = 48)] public Layouts.@s_172a8e0[] @animationsReplacements;
    [FieldOffset(40, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @notReplacedanimations;
    [FieldOffset(72)] public bool @skipAnimationIfNoReplacement;
}

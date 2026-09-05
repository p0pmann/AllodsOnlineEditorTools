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

[SerializedExtent(185)]
[XdbName("CreatureRandomReplaceAnimationsAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureRandomReplaceAnimationsAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @dontPlayNotReplacedAnimationExceptFor;
    [FieldOffset(104)] public ResourcePointer @priority;
    [FieldOffset(112)][EnumRef(typeof(Enums.@e_fdd0a0))] public int @replaceWhen;
    [FieldOffset(120, ArrayStride = 104)] public Layouts.@s_f73cd0[] @replacements;
    [FieldOffset(152, ArrayStride = 4)][EnumRef(typeof(Enums.@e_c5c6a0))] public int[] @slots;
    [FieldOffset(184)] public bool @restartOnVisualChange;
}

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

[SerializedExtent(156)]
[XdbName("StateComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StateComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72, ArrayStride = 12)] public Layouts.@s_d520a0[] @animationKeys;
    [FieldOffset(104, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(136)] public NullablePointer @component;
    [FieldOffset(144)] public ResourcePointer @controller;
    [FieldOffset(152)] public bool @inheritParentAnimationIfHaveNoOwn;
    [FieldOffset(153)] public bool @stopForOtherAnimation;
    [FieldOffset(154)] public bool @synchronizeAnimationPosition;
    [FieldOffset(155)] public bool @updateOnlyByFeedBacks;
}

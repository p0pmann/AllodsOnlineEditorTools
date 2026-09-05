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

[SerializedExtent(317)]
[XdbName("CreatureAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public Layouts.@s_1731d80 @advanced;
    [FieldOffset(224, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(256)][EnumRef(typeof(Enums.@e_1733130))] public int @channel;
    [FieldOffset(260)][EnumRef(typeof(Enums.@e_172ec00))] public int @channelOverrideControllers;
    [FieldOffset(264)][EnumRef(typeof(Enums.@e_172e910))] public int @channelOverrideMode;
    [FieldOffset(272)] public NullablePointer @channelOverrideScript;
    [FieldOffset(280)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
    [FieldOffset(288)] public string @specialController;
    [FieldOffset(312)][EnumRef(typeof(Enums.@e_172fe20))] public int @use;
    [FieldOffset(316)] public bool @dontFreezePrecast;
}

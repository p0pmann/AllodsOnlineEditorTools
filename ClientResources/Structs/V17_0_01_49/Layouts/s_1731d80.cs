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

[SerializedExtent(147)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1731d80
{
    [FieldOffset(8, ArrayStride = 24)] public Layouts.@s_172e680[] @animationKeysAction;
    [FieldOffset(40, ArrayStride = 24)] public Layouts.@s_172e680[] @animationKeysActionPeriod;
    [FieldOffset(72, ArrayStride = 24)] public Layouts.@s_172e680[] @animationKeysSound;
    [FieldOffset(104)] public Layouts.@s_172e5a0 @autoHasten;
    [FieldOffset(116)][EnumRef(typeof(Enums.@e_172ef40))] public int @changeChannelAfterFirstKey;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_1733130))] public int @channelAfterFirstKey;
    [FieldOffset(124)][EnumRef(typeof(Enums.@e_1729a90))] public int @offendType;
    [FieldOffset(128)] public float @speed;
    [FieldOffset(132)][EnumRef(typeof(Enums.@e_172f740))] public int @turnToTarget;
    [FieldOffset(136)][EnumRef(typeof(Enums.@e_172fae0))] public int @waitRealEvent;
    [FieldOffset(140)] public bool @backgroundAfterFirstKey;
    [FieldOffset(141)] public bool @denyAutoHasten;
    [FieldOffset(142)] public bool @disableRandomFirstFrame;
    [FieldOffset(143)] public bool @eventPlaybackEnd;
    [FieldOffset(144)] public bool @skipIfFixedIdleAnimation;
    [FieldOffset(145)] public bool @stopIfMoved;
    [FieldOffset(146)] public bool @stopIfRotated;
}

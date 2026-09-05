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

[StructSize(272)]
[XdbName("SkeletalAnimation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SkeletalAnimation
{
    [FieldOffset(36)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(60)] public Layouts.@s_1828d0 @aabbLastFrame;
    [FieldOffset(84)] public Layouts.@s_2106e0 @animation;
    [FieldOffset(96, ArrayStride = 40)] public Layouts.@s_b7fff0[] @animationEvents;
    [FieldOffset(128)] public FileRef @binaryFile;
    [FieldOffset(168)] public int @binaryVersion;
    [FieldOffset(172)] public float @blendTime;
    [FieldOffset(176)] public int @endFrame;
    [FieldOffset(180)] public float @fps;
    [FieldOffset(184)] public int @loopFrame;
    [FieldOffset(192, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @maySubstituteMissingAnimations;
    [FieldOffset(224)] public int @scriptID;
    [FieldOffset(232)] public string @scriptName;
    [FieldOffset(256)] public float @speed;
    [FieldOffset(260)] public int @startFrame;
    [FieldOffset(264)] public bool @looped;
}

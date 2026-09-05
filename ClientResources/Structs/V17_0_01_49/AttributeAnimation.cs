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

[StructSize(144)]
[XdbName("AttributeAnimation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AttributeAnimation
{
    [FieldOffset(40, ArrayStride = 64)] public Layouts.@s_17b720[] @animations;
    [FieldOffset(72)] public FileRef @binaryFile;
    [FieldOffset(112)] public int @endFrame;
    [FieldOffset(116)] public float @fps;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_17b7e0))] public int @interpolation;
    [FieldOffset(124)] public int @loopFrame;
    [FieldOffset(128)] public float @speed;
    [FieldOffset(132)] public int @startFrame;
    [FieldOffset(136)] public bool @looped;
    [FieldOffset(137)] public bool @syncWithSkeletalAnimation;
}

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

[SerializedExtent(84)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_187200
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_182fe0))] public int @BlendEffect;
    [FieldOffset(8)] public int @Color;
    [FieldOffset(12)][EnumRef(typeof(Enums.@e_183610))] public int @RenderEffect;
    [FieldOffset(16)] public float @ambientLightFactor;
    [FieldOffset(24)] public NullablePointer @colorDescriptor;
    [FieldOffset(32)][EnumRef(typeof(Enums.@e_183270))] public int @decalMirrorMode;
    [FieldOffset(36)] public float @fogFactor;
    [FieldOffset(40)] public string @name;
    [FieldOffset(64)] public float @pivotX;
    [FieldOffset(68)] public float @pivotY;
    [FieldOffset(72)] public float @virtualOffset;
    [FieldOffset(76)] public bool @UseLooping;
    [FieldOffset(77)] public bool @WorldSpaceEmitter;
    [FieldOffset(78)] public bool @decalEmitter;
    [FieldOffset(79)] public bool @decalInheritRotation;
    [FieldOffset(80)] public bool @distortionEmitter;
    [FieldOffset(81)] public bool @texFlipX;
    [FieldOffset(82)] public bool @texFlipY;
    [FieldOffset(83)] public bool @useScaleForVirtualOffset;
}

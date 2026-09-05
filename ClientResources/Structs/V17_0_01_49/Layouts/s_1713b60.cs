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

[SerializedExtent(172)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1713b60
{
    [FieldOffset(4)] public int @delay;
    [FieldOffset(8)] public ResourcePointer @effectAlias;
    [FieldOffset(16)] public Layouts.@s_c7c880 @effectAnimations;
    [FieldOffset(64)] public ResourcePointer @effectFx;
    [FieldOffset(72)] public int @fadeInTime;
    [FieldOffset(76)] public int @fadeOutTime;
    [FieldOffset(80)] public float @scale;
    [FieldOffset(84)] public bool @fixPoint;
    [FieldOffset(85)] public bool @lockScale;
    [FieldOffset(86)] public bool @muteFxSounds;
    [FieldOffset(92)] public bool @ignoreParentRotation;
    [FieldOffset(93)] public bool @ignoreParentTransparency;
    [FieldOffset(94)] public bool @ignoreProcedureFxScale;
    [FieldOffset(96)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(104)] public string @locatorName;
    [FieldOffset(128)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(136)] public NullablePointer @offendTime;
    [FieldOffset(144)] public Vector3 @offset;
    [FieldOffset(156)] public Vector3 @rotation;
    [FieldOffset(168)][EnumRef(typeof(Enums.@e_1713530))] public int @useVisObjectSettings;
}

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

[SerializedExtent(87)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c7d0c0
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
}

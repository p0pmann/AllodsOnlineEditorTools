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

[StructSize(88)]
[XdbName("TrailTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TrailTemplate
{
    [FieldOffset(36)] public int @color;
    [FieldOffset(40)] public NullablePointer @colorDescriptor;
    [FieldOffset(48)] public int @decayTime;
    [FieldOffset(52)] public int @fadeInTimeMSec;
    [FieldOffset(56)] public int @fadeOutTimeMSec;
    [FieldOffset(60)] public float @speedEnd;
    [FieldOffset(64)] public float @speedStart;
    [FieldOffset(68)] public float @stretchSpeed;
    [FieldOffset(72)] public int @texCoordsPeriodMs;
    [FieldOffset(80)] public ResourcePointer @trailTexture;
}

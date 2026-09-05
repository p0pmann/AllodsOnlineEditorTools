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

[StructSize(112)]
[XdbName("UserPostEffect")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UserPostEffect
{
    [FieldOffset(36)] public float @cycleTimeMS;
    [FieldOffset(40)] public int @fadeInTimeMSec;
    [FieldOffset(44)] public int @fadeOutTimeMSec;
    [FieldOffset(48)] public float @maxBumpFactor;
    [FieldOffset(52)] public float @maxColorFactor;
    [FieldOffset(56)] public float @maxScaleFactor;
    [FieldOffset(60)] public float @minBumpFactor;
    [FieldOffset(64)] public float @minColorFactor;
    [FieldOffset(68)] public float @minScaleFactor;
    [FieldOffset(72)] public int @priority;
    [FieldOffset(80)] public ResourcePointer @textureAdditive;
    [FieldOffset(88)] public ResourcePointer @textureBump;
    [FieldOffset(96)] public ResourcePointer @textureMultiply;
    [FieldOffset(104)] public bool @mulEffectPost;
}

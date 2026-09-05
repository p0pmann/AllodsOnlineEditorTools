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
[XdbName("AnimatedTexture")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AnimatedTexture
{
    [FieldOffset(36)] public float @bumpFactor;
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @bumpTextures;
    [FieldOffset(72)] public int @downScale;
    [FieldOffset(76)] public int @smoothRadius;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @textures;
}

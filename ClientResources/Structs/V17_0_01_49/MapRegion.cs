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

[StructSize(384)]
[XdbName("mapLoader.MapRegion")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MapRegion
{
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_a682b0[] @Areas;
    [FieldOffset(72)] public FileRef @BinaryFile;
    [FieldOffset(112)] public FileRef @BinaryFileDown;
    [FieldOffset(152)] public ResourcePointer @Layers;
    [FieldOffset(160, ArrayStride = 72)] public Layouts.@s_a68410[] @Objects;
    [FieldOffset(192, ArrayStride = 4)] public int[] @UsedLayers;
    [FieldOffset(224, ArrayStride = 32)] public ResourcePointer[][] @ambiences;
    [FieldOffset(256, ArrayStride = 8)] public NullablePointer[] @clientEntities;
    [FieldOffset(288, ArrayStride = 32)] public ResourcePointer[][] @musics;
    [FieldOffset(320, ArrayStride = 32)] public ResourcePointer[][] @tiles;
    [FieldOffset(352, ArrayStride = 32)] public ResourcePointer[][] @zoneLights;
}

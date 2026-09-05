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

[StructSize(280)]
[XdbName("TerrainPackInfo")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TerrainPackInfo
{
    [FieldOffset(40)] public FileRef @compressedTerrain;
    [FieldOffset(80)] public FileRef @extraOcclusion;
    [FieldOffset(120, ArrayStride = 16)] public Layouts.@s_c0e0f0[] @layers;
    [FieldOffset(152)] public ResourcePointer @lightmapDown;
    [FieldOffset(160)] public ResourcePointer @lightmapUp;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @splatMaps;
    [FieldOffset(200)] public FileRef @terraGenDown;
    [FieldOffset(240)] public FileRef @terraGenUp;
}

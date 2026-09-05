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

[StructSize(176)]
[XdbName("TerraLayers")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TerraLayers
{
    [FieldOffset(40)] public ResourcePointer @GrassMaterial;
    [FieldOffset(48, ArrayStride = 376)] public Layouts.@s_c13ae0[] @Layers;
    [FieldOffset(80)] public ResourcePointer @Material;
    [FieldOffset(88)] public ResourcePointer @WaterMaterial;
    [FieldOffset(96)] public ResourcePointer @atlas;
    [FieldOffset(104)] public FileRef @grassMask;
    [FieldOffset(144, ArrayStride = 136)] public Layouts.@s_c13f30[] @waterLayers;
}

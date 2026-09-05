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

[StructSize(152)]
[XdbName("CollisionMesh")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CollisionMesh
{
    [FieldOffset(36)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(64)] public FileRef @binaryFile;
    [FieldOffset(104)] public int @binaryVersion;
    [FieldOffset(108)] public int @clipMask;
    [FieldOffset(112, ArrayStride = 8)] public ResourcePointer[] @customMaterials;
    [FieldOffset(144)] public ResourcePointer @defaultMaterial;
}

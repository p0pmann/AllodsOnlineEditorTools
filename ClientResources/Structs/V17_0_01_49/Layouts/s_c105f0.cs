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

[SerializedExtent(72)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c105f0
{
    [FieldOffset(4)] public Layouts.@s_c10710 @bottom;
    [FieldOffset(24)] public ResourcePointer @foliageGeometry;
    [FieldOffset(32)] public float @maxScale;
    [FieldOffset(36)] public float @minScale;
    [FieldOffset(40)] public int @numLeaves;
    [FieldOffset(44)] public int @probability;
    [FieldOffset(48)] public ResourcePointer @texture;
    [FieldOffset(56)] public Layouts.@s_c10710 @top;
}

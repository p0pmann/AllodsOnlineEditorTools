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

[SerializedExtent(186)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_b76cf0
{
    [FieldOffset(8, ArrayStride = 24)] public string[] @linkedElements;
    [FieldOffset(40, ArrayStride = 20)] public Layouts.@s_b68500[] @lods;
    [FieldOffset(72)] public Layouts.@s_ac8470 @material;
    [FieldOffset(120)] public string @materialName;
    [FieldOffset(144)] public string @name;
    [FieldOffset(168)] public int @skinIndex;
    [FieldOffset(172)] public int @vertexBufferOffset;
    [FieldOffset(176)] public int @vertexDeclarationID;
    [FieldOffset(180)] public float @virtualOffset;
    [FieldOffset(184)] public bool @outliningEnabled;
    [FieldOffset(185)] public bool @useScaleForVirtualOffset;
}

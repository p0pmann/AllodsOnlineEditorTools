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

[SerializedExtent(44)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_21f370
{
    [FieldOffset(4)] public int @height;
    [FieldOffset(8)] public ResourcePointer @texture;
    [FieldOffset(16)] public int @width;
    [FieldOffset(20)] public int @x;
    [FieldOffset(24)] public float @xCoeffA;
    [FieldOffset(28)] public float @xCoeffRGB;
    [FieldOffset(32)] public int @y;
    [FieldOffset(36)] public float @yCoeffA;
    [FieldOffset(40)] public float @yCoeffRGB;
}

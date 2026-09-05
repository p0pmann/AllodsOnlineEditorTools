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

[SerializedExtent(32)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1cc5bb0
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_1cc5480))] public int @Align;
    [FieldOffset(8)] public float @HighPos;
    [FieldOffset(12)] public float @MaxSize;
    [FieldOffset(16)] public float @MinSize;
    [FieldOffset(20)] public float @Pos;
    [FieldOffset(24)] public float @Size;
    [FieldOffset(28)][EnumRef(typeof(Enums.@e_1cc6390))] public int @Sizing;
}

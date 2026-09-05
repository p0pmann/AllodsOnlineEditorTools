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

[SerializedExtent(56)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_ac3f10
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_ac49b0))] public int @addressModeU;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_ac49b0))] public int @addressModeV;
    [FieldOffset(12)] public Vector2 @offset;
    [FieldOffset(20)] public Vector2 @scale;
    [FieldOffset(32)] public ResourcePointer @texture;
    [FieldOffset(40)] public float @uTranslateSpeedAlpha;
    [FieldOffset(44)] public float @uTranslateSpeedRGB;
    [FieldOffset(48)] public float @vTranslateSpeedAlpha;
    [FieldOffset(52)] public float @vTranslateSpeedRGB;
}

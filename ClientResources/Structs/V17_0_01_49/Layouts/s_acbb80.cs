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

[SerializedExtent(35)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_acbb80
{
    [FieldOffset(4)] public float @borderThickness;
    [FieldOffset(8)] public float @cutoutMax;
    [FieldOffset(12)] public float @cutoutMin;
    [FieldOffset(16)] public ResourcePointer @cutoutTexture;
    [FieldOffset(24)] public float @scaleU;
    [FieldOffset(28)] public float @scaleV;
    [FieldOffset(32)] public bool @uRandomOffset;
    [FieldOffset(33)] public bool @use;
    [FieldOffset(34)] public bool @vRandomOffset;
}

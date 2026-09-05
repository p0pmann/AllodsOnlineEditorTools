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

[SerializedExtent(46)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_173cc60
{
    [FieldOffset(8)] public ResourcePointer @channelingFx;
    [FieldOffset(16)] public int @fadeInTime;
    [FieldOffset(20)] public int @fadeOutTime;
    [FieldOffset(24)] public float @fxLength;
    [FieldOffset(32)] public NullablePointer @offendTime;
    [FieldOffset(40)] public float @velocity;
    [FieldOffset(44)] public bool @scaleTextureU;
    [FieldOffset(45)] public bool @scaleTextureV;
}

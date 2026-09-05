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

[SerializedExtent(43)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_acbf60
{
    [FieldOffset(4)] public float @distortionMax;
    [FieldOffset(8)] public float @distortionMin;
    [FieldOffset(16)] public ResourcePointer @distortionTexture;
    [FieldOffset(24)] public float @scaleU;
    [FieldOffset(28)] public float @scaleV;
    [FieldOffset(32)] public float @uTranslateSpeed;
    [FieldOffset(36)] public float @vTranslateSpeed;
    [FieldOffset(40)] public bool @uRandomOffset;
    [FieldOffset(41)] public bool @use;
    [FieldOffset(42)] public bool @vRandomOffset;
}

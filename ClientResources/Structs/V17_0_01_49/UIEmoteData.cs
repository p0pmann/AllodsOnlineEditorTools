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

[SerializedExtent(176)]
[XdbName("UIEmoteData")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIEmoteData
{
    [FieldOffset(48)] public NullablePointer @animation;
    [FieldOffset(56)] public ResourcePointer @image;
    [FieldOffset(64)] public ResourcePointer @image2;
    [FieldOffset(72)] public ResourcePointer @mood;
    [FieldOffset(80)] public TextFileRef @textNoTarget;
    [FieldOffset(112)] public TextFileRef @textTarget;
    [FieldOffset(144, ArrayStride = 40)] public Layouts.@s_a96bc0[] @voiceOvers;
}

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

[StructSize(184)]
[XdbName("avatarPopulation.service.post.PostType")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PostType
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public int @lengthLimit;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @posterConditions;
    [FieldOffset(144)] public int @postsLimit;
    [FieldOffset(152)] public string @sysName;
    [FieldOffset(176)] public bool @isPersistent;
}

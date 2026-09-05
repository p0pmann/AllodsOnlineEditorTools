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

[SerializedExtent(105)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1071f30
{
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @availableTalents;
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public TextFileRef @name;
    [FieldOffset(104)] public bool @hasCustomRank;
}

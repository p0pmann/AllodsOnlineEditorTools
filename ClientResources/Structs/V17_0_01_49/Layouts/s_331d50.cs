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

[SerializedExtent(64)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_331d50
{
    [FieldOffset(4)] public bool @external;
    [FieldOffset(8)] public string @imageName;
    [FieldOffset(32, ArrayStride = 8)] public ResourcePointer[] @maps;
}

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

[SerializedExtent(112)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_95af40
{
    [FieldOffset(8)] public TextFileRef @aliases;
    [FieldOffset(40)] public int @argCount;
    [FieldOffset(48)] public string @id;
    [FieldOffset(72)] public TextFileRef @prefix;
    [FieldOffset(104)] public ResourcePointer @question;
}

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

[SerializedExtent(120)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1635110
{
    [FieldOffset(8)] public ResourcePointer @finalQuest;
    [FieldOffset(16)] public TextFileRef @notReadytext;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @path;
    [FieldOffset(80)] public ResourcePointer @startQuest;
    [FieldOffset(88)] public TextFileRef @text;
}

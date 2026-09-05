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

[SerializedExtent(225)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1bc0a20
{
    [FieldOffset(4)] public int @apiVersion;
    [FieldOffset(8)] public string @author;
    [FieldOffset(32)] public long @buildTime;
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public TextFileRef @license;
    [FieldOffset(104)] public TextFileRef @name;
    [FieldOffset(136)] public TextFileRef @sourceLink;
    [FieldOffset(168)] public TextFileRef @supportLink;
    [FieldOffset(200)] public string @version;
    [FieldOffset(224)] public bool @useCommonScripts;
}

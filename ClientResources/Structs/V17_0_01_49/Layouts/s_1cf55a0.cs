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

[SerializedExtent(109)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1cf55a0
{
    [FieldOffset(8)] public string @alias;
    [FieldOffset(32)] public FileRef @fontFileName;
    [FieldOffset(72)] public TextFileRef @systemFontsFileName;
    [FieldOffset(104)] public bool @antialiasing;
    [FieldOffset(105)] public bool @bold;
    [FieldOffset(106)] public bool @italic;
    [FieldOffset(107)] public bool @strikethrough;
    [FieldOffset(108)] public bool @underline;
}

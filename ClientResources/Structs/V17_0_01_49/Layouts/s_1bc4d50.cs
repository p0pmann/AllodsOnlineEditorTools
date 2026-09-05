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

[SerializedExtent(97)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1bc4d50
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_1bc4e40))] public int @activationType;
    [FieldOffset(8, ArrayStride = 24)] public string[] @defaultKeys;
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)] public string @sysName;
    [FieldOffset(96)] public bool @anyMods;
}

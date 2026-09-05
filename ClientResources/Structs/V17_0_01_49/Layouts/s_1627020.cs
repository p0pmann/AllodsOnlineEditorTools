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

[SerializedExtent(113)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1627020
{
    [FieldOffset(40)] public NullablePointer @maxValue;
    [FieldOffset(48)] public NullablePointer @minValue;
    [FieldOffset(56)] public TextFileRef @name;
    [FieldOffset(88)] public string @sysName;
    [FieldOffset(112)] public bool @resetOnStretch;
}

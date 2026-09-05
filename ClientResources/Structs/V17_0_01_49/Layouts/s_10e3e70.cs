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

[SerializedExtent(72)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_10e3e70
{
    [FieldOffset(8)] public NullablePointer @amount;
    [FieldOffset(16)] public ResourcePointer @baseItem;
    [FieldOffset(24)] public ResourcePointer @itemMallItem;
    [FieldOffset(32)][EnumRef(typeof(Enums.@e_10e3b30))] public int @tag;
    [FieldOffset(40)] public TextFileRef @text;
}

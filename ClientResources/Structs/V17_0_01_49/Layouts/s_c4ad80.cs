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
public partial class @s_c4ad80
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public NullablePointer @actionBarCancel;
    [FieldOffset(80)] public NullablePointer @actionBarComplite;
    [FieldOffset(88)] public NullablePointer @actionBarStart;
    [FieldOffset(96)][EnumRef(typeof(Enums.@e_c4a6f0))] public int @precastType;
    [FieldOffset(104)] public NullablePointer @wholeCasting;
}

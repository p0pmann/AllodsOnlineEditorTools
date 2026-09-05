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

[SerializedExtent(56)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1965180
{
    [FieldOffset(8, ArrayStride = 16)] public Layouts.@s_1965070[] @levels;
    [FieldOffset(40)] public ResourcePointer @race;
    [FieldOffset(48)][EnumRef(typeof(Enums.@e_1210e30))] public int @slot;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_1210e30))] public int @zodiacSignSlot;
}

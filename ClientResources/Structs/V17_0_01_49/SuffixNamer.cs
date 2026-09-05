// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49;

[StructSize(136)]
[XdbName("gameMechanics.world.worldDrop.SuffixNamer")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SuffixNamer
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_11507a0[] @items;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_1150a60))] public int[] @name;
    [FieldOffset(104, ArrayStride = 48)] public Layouts.@s_1150890[] @prefixes;
}

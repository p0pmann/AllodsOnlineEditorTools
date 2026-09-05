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

[StructSize(176)]
[XdbName("gameMechanics.world.worldDrop.WorldDropSuffix")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WorldDropSuffix
{
    [FieldOffset(40, ArrayStride = 24)] public Layouts.@s_10d72b0[] @additionalSpecialStats;
    [FieldOffset(72)] public ResourcePointer @group;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112, ArrayStride = 8)] public ResourcePointer[] @specialStats;
    [FieldOffset(144, ArrayStride = 4)][EnumRef(typeof(Enums.@e_158dc70))] public int[] @stats;
}

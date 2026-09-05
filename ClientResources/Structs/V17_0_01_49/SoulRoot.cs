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

[StructSize(168)]
[XdbName("gameMechanics.world.gameRoot.SoulRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SoulRoot
{
    [FieldOffset(40, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(72)] public TextFileRef @description;
    [FieldOffset(104)] public NullablePointer @minSoulExpLevel;
    [FieldOffset(112)] public int @rerollPriceInLevel;
    [FieldOffset(120, ArrayStride = 12)] public Layouts.@s_10d1e20[] @soulLevels;
    [FieldOffset(152)] public ResourcePointer @soulPointsCurrency;
    [FieldOffset(160)] public ResourcePointer @talentGraph;
}

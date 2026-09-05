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

[StructSize(80)]
[XdbName("itemService.compendium.CompendiumLevelReward")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CompendiumLevelReward
{
    [FieldOffset(36)] public int @count;
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(72)] public NullablePointer @reward;
}

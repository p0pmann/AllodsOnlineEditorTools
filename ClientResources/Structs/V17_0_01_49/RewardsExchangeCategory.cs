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

[StructSize(104)]
[XdbName("itemService.rewardsExchange.RewardsExchangeCategory")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RewardsExchangeCategory
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72, ArrayStride = 32)] public Layouts.@s_10c4a70[] @rewards;
}

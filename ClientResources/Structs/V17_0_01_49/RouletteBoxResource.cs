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
[XdbName("itemService.elements.roulettebox.RouletteBoxResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RouletteBoxResource
{
    [FieldOffset(36)] public int @bonusChipCount;
    [FieldOffset(40)] public int @bonusCounterValueMax;
    [FieldOffset(44)] public int @bonusSlotsCount;
    [FieldOffset(48)] public ResourcePointer @chipResource;
    [FieldOffset(56)] public int @luckyRollFactor;
    [FieldOffset(60)] public int @maxStakesPerRound;
    [FieldOffset(64)] public int @maxValue;
    [FieldOffset(72, ArrayStride = 16)] public Layouts.@s_112f6c0[] @suiteEntries;
}

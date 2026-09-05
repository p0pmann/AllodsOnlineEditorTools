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

[SerializedExtent(96)]
[XdbName("gameMechanics.elements.scalers.ScalerRangeTransform")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScalerRangeTransform
{
    [FieldOffset(48)] public NullablePointer @rangeFromMax;
    [FieldOffset(56)] public NullablePointer @rangeFromMin;
    [FieldOffset(64)] public NullablePointer @rangeToMax;
    [FieldOffset(72)] public NullablePointer @rangeToMin;
    [FieldOffset(80)] public NullablePointer @valueIfLess;
    [FieldOffset(88)] public NullablePointer @valueIfMore;
}

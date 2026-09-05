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

[SerializedExtent(68)]
[XdbName("gameMechanics.elements.calcers.CalcerLongMulFloat")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CalcerLongMulFloat
{
    [FieldOffset(48)] public NullablePointer @calcerFloat;
    [FieldOffset(56)] public NullablePointer @calcerLong;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_146a4f0))] public int @rounding;
}

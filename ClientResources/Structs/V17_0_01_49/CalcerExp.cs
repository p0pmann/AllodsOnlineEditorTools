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

[SerializedExtent(88)]
[XdbName("gameMechanics.elements.calcers.CalcerExp")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CalcerExp
{
    [FieldOffset(44)] public float @base;
    [FieldOffset(48)] public NullablePointer @baseCalc;
    [FieldOffset(56)] public float @pow;
    [FieldOffset(64)] public NullablePointer @powCalc;
    [FieldOffset(72)] public float @sum;
    [FieldOffset(80)] public NullablePointer @sumCalc;
}

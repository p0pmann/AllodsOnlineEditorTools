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

[SerializedExtent(52)]
[XdbName("gameMechanics.elements.formulas.LinearMultiplierFormula")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LinearMultiplierFormula
{
    [FieldOffset(44)] public float @multiplier;
    [FieldOffset(48)] public float @summand;
}

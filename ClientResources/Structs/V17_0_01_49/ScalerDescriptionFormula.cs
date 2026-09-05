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

[SerializedExtent(48)]
[XdbName("gameMechanics.elements.scalers.ScalerDescriptionFormula")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScalerDescriptionFormula
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_156b3d0))] public int @formula;
}

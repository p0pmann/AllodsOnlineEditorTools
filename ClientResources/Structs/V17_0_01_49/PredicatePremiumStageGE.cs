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

[SerializedExtent(56)]
[XdbName("gameMechanics.elements.predicates.PredicatePremiumStageGE")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicatePremiumStageGE
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(52)] public int @stageNumber;
}

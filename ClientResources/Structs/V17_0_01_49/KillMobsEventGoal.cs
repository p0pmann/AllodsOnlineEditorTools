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

[StructSize(128)]
[XdbName("gameMechanics.elements.scenarios.eventGoals.KillMobsEventGoal")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @KillMobsEventGoal
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public TextFileRef @objective;
}

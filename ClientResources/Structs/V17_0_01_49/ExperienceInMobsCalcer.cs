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
[XdbName("gameMechanics.elements.calcers.ExperienceInMobsCalcer")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ExperienceInMobsCalcer
{
    [FieldOffset(44)] public int @mobCount;
    [FieldOffset(48)] public int @mobLevel;
}

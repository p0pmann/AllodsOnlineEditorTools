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

[SerializedExtent(70)]
[XdbName("CreatureDisableHitsAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureDisableHitsAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)] public bool @disableCrits;
    [FieldOffset(69)] public bool @disableHits;
}

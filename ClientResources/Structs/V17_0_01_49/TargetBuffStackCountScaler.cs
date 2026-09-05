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

[SerializedExtent(66)]
[XdbName("gameMechanics.elements.scalers.TargetBuffStackCountScaler")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TargetBuffStackCountScaler
{
    [FieldOffset(48)] public ResourcePointer @buff;
    [FieldOffset(56)] public float @mul;
    [FieldOffset(60)] public float @sum;
    [FieldOffset(64)] public bool @anyRank;
    [FieldOffset(65)] public bool @onlyFromMaster;
}

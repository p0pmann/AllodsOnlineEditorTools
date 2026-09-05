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

[SerializedExtent(69)]
[XdbName("gameMechanics.elements.scalers.ScalerBuff")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScalerBuff
{
    [FieldOffset(48)] public ResourcePointer @buff;
    [FieldOffset(56)] public float @multiplier;
    [FieldOffset(60)] public float @stackCountSummand;
    [FieldOffset(64)] public float @summand;
    [FieldOffset(68)] public bool @checkCaster;
}

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
[XdbName("gameMechanics.elements.scalers.ScalerAddBuff")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScalerAddBuff
{
    [FieldOffset(48)] public ResourcePointer @buff;
    [FieldOffset(56)] public float @buffStackFactor;
    [FieldOffset(60)] public float @initialValueFactor;
    [FieldOffset(64)] public float @summand;
}

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

[SerializedExtent(57)]
[XdbName("gameMechanics.constructor.schemes.item.RewardExchangeItemProvider")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RewardExchangeItemProvider
{
    [FieldOffset(48)] public NullablePointer @item;
    [FieldOffset(56)] public bool @createCopy;
}

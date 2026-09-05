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
[XdbName("gameMechanics.constructor.schemes.item.InactiveMetaItemProvider")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InactiveMetaItemProvider
{
    [FieldOffset(44)] public float @activationFactor;
    [FieldOffset(48)] public ResourcePointer @item;
    [FieldOffset(56)] public bool @enchancer;
}

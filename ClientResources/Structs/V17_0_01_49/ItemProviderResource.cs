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

[StructSize(48)]
[XdbName("gameMechanics.constructor.schemes.item.ItemProviderResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemProviderResource
{
    [FieldOffset(40)] public NullablePointer @itemProvider;
}

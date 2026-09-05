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

[SerializedExtent(80)]
[XdbName("gameMechanics.constructor.schemes.collectionEditions.ItemsEditionResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemsEditionResource
{
    [FieldOffset(40, ArrayStride = 4)] public Layouts.Empty[] @bundles;
    [FieldOffset(72)] public ResourcePointer @unlock;
}

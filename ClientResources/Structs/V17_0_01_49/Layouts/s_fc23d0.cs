// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(57)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_fc23d0
{
    [FieldOffset(8)] public ResourcePointer @image;
    [FieldOffset(16)] public ResourcePointer @quest;
    [FieldOffset(24, ArrayStride = 8)] public ResourcePointer[] @requiredItems;
    [FieldOffset(56)] public bool @isAvailableOnP2P;
}

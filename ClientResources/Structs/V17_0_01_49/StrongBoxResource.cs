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

[StructSize(104)]
[XdbName("itemService.elements.strongbox.StrongBoxResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StrongBoxResource
{
    [FieldOffset(40)] public ResourcePointer @box;
    [FieldOffset(48, ArrayStride = 4)] public int[] @cardsCosts;
    [FieldOffset(80)] public int @deckStartSize;
    [FieldOffset(88)] public ResourcePointer @key;
    [FieldOffset(96)] public int @luckyCountCap;
    [FieldOffset(100)] public bool @bindReward;
}

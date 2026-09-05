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

[StructSize(96)]
[XdbName("gameMechanics.constructor.schemes.quest.chain.QuestChainNode")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestChainNode
{
    [FieldOffset(40)] public ResourcePointer @image;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @nextNodes;
    [FieldOffset(80)] public ResourcePointer @quest;
    [FieldOffset(88)] public int @x;
    [FieldOffset(92)] public int @y;
}

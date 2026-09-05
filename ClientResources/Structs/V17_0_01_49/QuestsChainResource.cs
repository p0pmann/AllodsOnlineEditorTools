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

[StructSize(112)]
[XdbName("gameMechanics.constructor.schemes.quest.chain.QuestsChainResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @QuestsChainResource
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @nodes;
    [FieldOffset(104)] public NullablePointer @reward;
}

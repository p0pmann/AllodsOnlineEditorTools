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

[SerializedExtent(108)]
[XdbName("CreatureChangeVisItemsAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureChangeVisItemsAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 24)] public Layouts.@s_173b3e0[] @items;
    [FieldOffset(104)] public bool @isGfxCondition;
    [FieldOffset(105)] public bool @leaveWeapons;
    [FieldOffset(106)] public bool @notForDolls;
    [FieldOffset(107)] public bool @removeAllItems;
}

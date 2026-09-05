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

[SerializedExtent(112)]
[XdbName("gameMechanics.elements.skills.diceCraft.DiceCraftRecipeInfo")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DiceCraftRecipeInfo
{
    [FieldOffset(48, ArrayStride = 16)] public Layouts.@s_11aee80[] @items;
    [FieldOffset(80, ArrayStride = 32)] public Layouts.@s_11aede0[] @results;
}

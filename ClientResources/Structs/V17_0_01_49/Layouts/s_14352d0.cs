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

[SerializedExtent(16)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_14352d0
{
    [FieldOffset(4)] public int @greyListCost;
    [FieldOffset(8)][EnumRef(typeof(Enums.@e_fbd2a0))] public int @type;
    [FieldOffset(12)] public int @whiteListCost;
}

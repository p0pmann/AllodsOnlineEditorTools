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

[SerializedExtent(128)]
[XdbName("CreatureTakeBowStringAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureTakeBowStringAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_17127b0))] public int @creatureLocator;
    [FieldOffset(72)] public string @creatureLocatorName;
    [FieldOffset(96)] public string @itemLocatorName;
    [FieldOffset(120)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @itemsSlot;
    [FieldOffset(124)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
}

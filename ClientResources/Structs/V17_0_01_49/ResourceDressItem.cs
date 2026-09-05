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

[SerializedExtent(72)]
[XdbName("gameMechanics.elements.resources.ResourceDressItem")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceDressItem
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(60)] public int @count;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_c5c6a0))] public int @slot;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_fefe10))] public int @type;
}

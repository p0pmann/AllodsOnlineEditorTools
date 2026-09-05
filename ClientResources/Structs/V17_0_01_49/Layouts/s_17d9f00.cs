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

[SerializedExtent(45)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17d9f00
{
    [FieldOffset(8)] public string @guild;
    [FieldOffset(32)] public int @level;
    [FieldOffset(36)] public int @rankIndex;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_160e710))] public int @tabardType;
    [FieldOffset(44)] public bool @isLeader;
}

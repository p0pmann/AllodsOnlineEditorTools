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

[SerializedExtent(61)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_f66610
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_10ab4a0))] public int @quality;
    [FieldOffset(40)] public ResourcePointer @socket;
    [FieldOffset(48)] public int @x;
    [FieldOffset(52)] public int @y;
    [FieldOffset(56)] public int @id;
    [FieldOffset(60)] public bool @start;
}

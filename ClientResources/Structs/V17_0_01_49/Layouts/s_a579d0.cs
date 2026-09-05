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

[SerializedExtent(76)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_a579d0
{
    [FieldOffset(40)] public WString @matchUser;
    [FieldOffset(64)] public int @maxLength;
    [FieldOffset(68)] public int @minLength;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_a5bac0))] public int @transformation;
}

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

[SerializedExtent(60)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1009d40
{
    [FieldOffset(40)] public ResourcePointer @currency;
    [FieldOffset(48)] public long @gearScorePoints;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_100ae70))] public int @slot;
}

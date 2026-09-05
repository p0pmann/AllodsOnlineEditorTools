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

[SerializedExtent(65)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_19f9e60
{
    [FieldOffset(4)] public int @adddedDelay;
    [FieldOffset(8)] public ResourcePointer @effect;
    [FieldOffset(16)] public int @fadeInTime;
    [FieldOffset(20)] public int @fadeOutTime;
    [FieldOffset(24)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(32)] public string @locatorName;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
    [FieldOffset(60)] public int @rate;
    [FieldOffset(64)] public bool @fixPoint;
}

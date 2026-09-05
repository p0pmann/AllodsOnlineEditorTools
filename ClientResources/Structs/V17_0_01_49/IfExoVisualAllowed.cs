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

[SerializedExtent(49)]
[XdbName("IfExoVisualAllowed")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @IfExoVisualAllowed
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_18fd0a0))] public int @checkType;
    [FieldOffset(48)] public bool @checkIsNotSet;
}

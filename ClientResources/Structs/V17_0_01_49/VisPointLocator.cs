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

[SerializedExtent(92)]
[XdbName("VisPointLocator")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisPointLocator
{
    [FieldOffset(36)] public Vector3 @shift;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_1716760))] public int @from;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(64)] public string @locatorName;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_c5d710))] public int @member;
}

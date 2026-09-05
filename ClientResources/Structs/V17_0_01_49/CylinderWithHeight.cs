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

[SerializedExtent(52)]
[XdbName("gameMechanics.constructor.schemes.spell.area.CylinderWithHeight")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CylinderWithHeight
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_11348c0))] public int @objectsProvider;
    [FieldOffset(44)] public float @bottomPlane;
    [FieldOffset(48)] public float @topPlane;
}

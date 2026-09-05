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

[SerializedExtent(60)]
[XdbName("gameMechanics.world.stronghold.Beast")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Beast
{
    [FieldOffset(48)] public ResourcePointer @mob;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_f801f0))] public int @type;
}

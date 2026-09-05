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

[StructSize(40)]
[XdbName("gameMechanics.world.pet.PetTypeResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PetTypeResource
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_15c7810))] public int @type;
}

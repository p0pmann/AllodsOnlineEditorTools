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

[SerializedExtent(73)]
[XdbName("gameMechanics.world.ship.elements.ResourceEnergy")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceEnergy
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(64)] public NullablePointer @energy;
    [FieldOffset(72)] public bool @safe;
}

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

[StructSize(184)]
[XdbName("gameMechanics.world.ship.ShipResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(76)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public NullablePointer @spawnLocation;
    [FieldOffset(120)] public bool @manualCorpulence;
    [FieldOffset(132)] public int @health;
    [FieldOffset(136)] public ResourcePointer @image;
    [FieldOffset(144, ArrayStride = 16)] public Layouts.@s_15f3db0[] @visualShips;
    [FieldOffset(176)] public bool @drawInterface;
}

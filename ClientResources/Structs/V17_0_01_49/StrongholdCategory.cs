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

[StructSize(120)]
[XdbName("gameMechanics.world.stronghold.StrongholdCategory")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StrongholdCategory
{
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @all;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public float @productionEfficiency;
    [FieldOffset(116)] public float @weight;
}

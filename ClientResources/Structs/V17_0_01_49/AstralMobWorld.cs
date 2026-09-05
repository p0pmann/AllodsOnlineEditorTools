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

[StructSize(200)]
[XdbName("gameMechanics.world.astralMob.AstralMobWorld")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralMobWorld
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(76)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public NullablePointer @spawnLocation;
    [FieldOffset(120)] public bool @manualCorpulence;
    [FieldOffset(136)] public ResourcePointer @visMob;
    [FieldOffset(152)] public ResourcePointer @image;
    [FieldOffset(160)] public ResourcePointer @quality;
    [FieldOffset(168, ArrayStride = 16)] public Layouts.@s_152d3a0[] @techLevelSpecific;
}

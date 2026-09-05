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

[StructSize(88)]
[XdbName("gameMechanics.world.stronghold.StrongholdRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @StrongholdRoot
{
    [FieldOffset(40)] public Layouts.@s_1039f40 @dungeon;
    [FieldOffset(80)] public ResourcePointer @initialCategory;
}

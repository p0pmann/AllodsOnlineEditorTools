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

[StructSize(104)]
[XdbName("gameMechanics.world.characterVariations.CharacterRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CharacterRoot
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_1537120[] @factions;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @sexes;
}

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
[XdbName("gameMechanics.world.gameRoot.ExperienceSlicesRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ExperienceSlicesRoot
{
    [FieldOffset(40)] public ResourcePointer @defaultSlice;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @extraSlices;
    [FieldOffset(80)] public ResourcePointer @pvpSlice;
}

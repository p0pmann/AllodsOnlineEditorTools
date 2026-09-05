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

[StructSize(224)]
[XdbName("gameMechanics.world.ActionOpenLootBag")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ActionOpenLootBag
{
    [FieldOffset(48)] public Layouts.@s_151d4a0 @contextActionInfo;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @interruptsActionGroups;
    [FieldOffset(208)] public NullablePointer @useVisScipt;
    [FieldOffset(216)] public ResourcePointer @visualScripts;
}

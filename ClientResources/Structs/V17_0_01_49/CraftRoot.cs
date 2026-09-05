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

[StructSize(280)]
[XdbName("gameMechanics.world.gameRoot.CraftRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CraftRoot
{
    [FieldOffset(40, ArrayStride = 72)] public Layouts.@s_155e280[] @activation;
    [FieldOffset(72, ArrayStride = 16)] public Layouts.@s_155e500[] @activationCost;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @ignoredBindingComponents;
    [FieldOffset(136)] public Layouts.@s_155e490 @inspiration;
    [FieldOffset(176)] public ResourcePointer @inspirationRate;
    [FieldOffset(184, ArrayStride = 8)] public ResourcePointer[] @metaActivators;
    [FieldOffset(216, ArrayStride = 8)] public ResourcePointer[] @metaAgents;
    [FieldOffset(248, ArrayStride = 80)] public Layouts.@s_155e5b0[] @toolImprovers;
}

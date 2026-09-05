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

[StructSize(448)]
[XdbName("GameStateRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameStateRoot
{
    [FieldOffset(40)] public TextFileRef @clientApplicationName;
    [FieldOffset(72)] public ResourcePointer @credits;
    [FieldOffset(80)] public Layouts.@s_3309d0 @deniedWordsFilter;
    [FieldOffset(248)] public ResourcePointer @firstPaymentBonusRoot;
    [FieldOffset(256)] public ResourcePointer @forceDisableParallelUI;
    [FieldOffset(264)] public Layouts.@s_4a4fe0 @fpsDetectorInfo;
    [FieldOffset(328)] public ResourcePointer @gameMechanics;
    [FieldOffset(336)] public FileRef @globalAddonFileRef;
    [FieldOffset(376, ArrayStride = 4)] public int[] @latencyRangesMs;
    [FieldOffset(408, ArrayStride = 12)] public Layouts.@s_4a5140[] @loadingProgressStages;
    [FieldOffset(440)] public ResourcePointer @userAddonsRestrictionsContentKey;
}

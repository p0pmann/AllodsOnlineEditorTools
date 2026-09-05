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

[SerializedExtent(244)]
[XdbName("GameViewTestCloneCreature")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewTestCloneCreature
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(156)] public int @iCount;
    [FieldOffset(160)] public Vector2 @iStep;
    [FieldOffset(168)] public int @jCount;
    [FieldOffset(172)] public Vector2 @jStep;
    [FieldOffset(184)] public string @nameStart;
    [FieldOffset(208)] public string @patternCreature;
    [FieldOffset(232)] public Vector3 @startOffset;
}

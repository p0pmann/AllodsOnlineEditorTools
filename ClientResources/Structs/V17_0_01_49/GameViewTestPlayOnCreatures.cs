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

[SerializedExtent(256)]
[XdbName("GameViewTestPlayOnCreatures")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewTestPlayOnCreatures
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160, ArrayStride = 40)] public Layouts.@s_17d7b20[] @creatureIntervals;
    [FieldOffset(192, ArrayStride = 24)] public string[] @creatures;
    [FieldOffset(224)] public ResourcePointer @script;
    [FieldOffset(232)] public string @variableCreature;
}

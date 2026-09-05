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

[SerializedExtent(324)]
[XdbName("GameViewActionCastSpell")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionCastSpell
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @casterCreature;
    [FieldOffset(184, ArrayStride = 8)] public NullablePointer[] @effectActions;
    [FieldOffset(216)] public Layouts.@s_17c9f00 @interruptParams;
    [FieldOffset(240)] public Layouts.@s_17ca1a0 @precastParams;
    [FieldOffset(252)] public int @prepareDuration;
    [FieldOffset(256, ArrayStride = 24)] public string[] @secondaryTargetCreatures;
    [FieldOffset(288)] public ResourcePointer @spell;
    [FieldOffset(296)] public string @targetCreature;
    [FieldOffset(320)] public float @throwSpeed;
}

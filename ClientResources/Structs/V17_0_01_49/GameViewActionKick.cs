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

[SerializedExtent(238)]
[XdbName("GameViewActionKick")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionKick
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @offenderCreature;
    [FieldOffset(184)] public ResourcePointer @producer;
    [FieldOffset(192)] public string @targetCreature;
    [FieldOffset(220)] public float @distance;
    [FieldOffset(224)] public float @friction;
    [FieldOffset(228)] public float @horSpeed;
    [FieldOffset(232)] public float @topZ;
    [FieldOffset(236)] public bool @showLootBag;
    [FieldOffset(237)] public bool @useGameSettings;
}

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

[SerializedExtent(248)]
[XdbName("GameViewActionMagicAttack")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GameViewActionMagicAttack
{
    [FieldOffset(40)] public Layouts.@s_179bdb0 @playbackParameters;
    [FieldOffset(160)] public string @offenderCreature;
    [FieldOffset(184)] public ResourcePointer @producer;
    [FieldOffset(192)] public string @targetCreature;
    [FieldOffset(220)] public int @damageAbsorbed;
    [FieldOffset(224)] public int @damageBlocked;
    [FieldOffset(228)][EnumRef(typeof(Enums.@e_160d640))] public int @element;
    [FieldOffset(232)][EnumRef(typeof(Enums.@e_179cf60))] public int @source;
    [FieldOffset(236)] public bool @isCritical;
    [FieldOffset(237)] public bool @isDamageDealt;
    [FieldOffset(238)] public bool @isLethal;
    [FieldOffset(239)] public bool @isOverkill;
    [FieldOffset(244)] public int @damageResisted;
}

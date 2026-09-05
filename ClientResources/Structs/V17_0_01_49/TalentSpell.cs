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

[SerializedExtent(88)]
[XdbName("gameMechanics.constructor.schemes.talent.TalentSpell")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TalentSpell
{
    [FieldOffset(40)] public NullablePointer @parentTalent;
    [FieldOffset(48)][EnumRef(typeof(Enums.@e_10a8820))] public int @priorityType;
    [FieldOffset(56)] public ResourcePointer @unlock;
    [FieldOffset(72)] public ResourcePointer @pairSpell;
    [FieldOffset(80)] public ResourcePointer @spell;
}

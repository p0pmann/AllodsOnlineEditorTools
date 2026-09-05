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

[SerializedExtent(68)]
[XdbName("gameMechanics.constructor.schemes.spell.SpellSimpleCooldown")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SpellSimpleCooldown
{
    [FieldOffset(40)] public long @duration;
    [FieldOffset(48)] public ResourcePointer @group;
    [FieldOffset(56)] public NullablePointer @scaler;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_1609c90))] public int @stage;
}

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

[SerializedExtent(109)]
[XdbName("gameMechanics.elements.resources.ResourceMana")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceMana
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(60)] public float @mana;
    [FieldOffset(64, ArrayStride = 4)][EnumRef(typeof(Enums.@e_15b2850))] public int[] @manaType;
    [FieldOffset(96)] public NullablePointer @rawManaScaler;
    [FieldOffset(104)][EnumRef(typeof(Enums.@e_15318e0))] public int @source;
    [FieldOffset(108)] public bool @scaleByWeaponSpeed;
}

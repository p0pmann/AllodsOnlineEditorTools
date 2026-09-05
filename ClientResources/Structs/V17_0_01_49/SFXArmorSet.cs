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

[StructSize(64)]
[XdbName("SFXArmorSet")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SFXArmorSet
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_c65760))] public int @armorMaterial;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_c65760))] public int @shieldMaterial;
    [FieldOffset(48)] public ResourcePointer @weaponItemClass;
    [FieldOffset(56)][EnumRef(typeof(Enums.@e_c65760))] public int @weaponMaterial;
    [FieldOffset(60)] public float @weaponSize;
}

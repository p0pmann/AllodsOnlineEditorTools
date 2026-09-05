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

[SerializedExtent(361)]
[XdbName("VisItemEffectsRanged")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisItemEffectsRanged
{
    [FieldOffset(48)] public string @attachArrowLocatorInItem;
    [FieldOffset(72, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @attackAnimation;
    [FieldOffset(104, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @cheapShotAnimation;
    [FieldOffset(136, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @cheapShotStartAnimation;
    [FieldOffset(168)] public ResourcePointer @explosion;
    [FieldOffset(176, ArrayStride = 48)] public Layouts.@s_c4ee20[] @holdAnimations;
    [FieldOffset(208, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @loadAnimation;
    [FieldOffset(240, ArrayStride = 48)] public Layouts.@s_c4ee20[] @loadHoldAnimations;
    [FieldOffset(272)] public ResourcePointer @projectile;
    [FieldOffset(280, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @rapidFireAnimation;
    [FieldOffset(312, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @readyAnimation;
    [FieldOffset(344)][EnumRef(typeof(Enums.@e_1712670))] public int @rotateArrowInItem;
    [FieldOffset(352)] public ResourcePointer @script;
    [FieldOffset(360)] public bool @useTakeStringInHand;
}

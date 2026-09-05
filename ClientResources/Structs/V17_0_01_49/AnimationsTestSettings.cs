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

[StructSize(176)]
[XdbName("AnimationsTestSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AnimationsTestSettings
{
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_17cbcc0[] @animationsSettings;
    [FieldOffset(72)] public ResourcePointer @bow;
    [FieldOffset(80)] public ResourcePointer @crossBow;
    [FieldOffset(88)] public ResourcePointer @shield;
    [FieldOffset(96, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @usedAnimations;
    [FieldOffset(128)] public ResourcePointer @wand;
    [FieldOffset(136)] public ResourcePointer @weapon1H_mainHand;
    [FieldOffset(144)] public ResourcePointer @weapon1H_offHand;
    [FieldOffset(152)] public ResourcePointer @weapon2H;
    [FieldOffset(160)] public ResourcePointer @weapon2L;
    [FieldOffset(168)] public bool @useAnimationOnlyFromList;
}

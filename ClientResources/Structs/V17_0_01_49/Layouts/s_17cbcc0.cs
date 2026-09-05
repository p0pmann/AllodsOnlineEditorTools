// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(52)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17cbcc0
{
    [FieldOffset(8, ArrayStride = 24)] public Layouts.@s_c8d420[] @addedItems;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(44)] public bool @bow;
    [FieldOffset(45)] public bool @crossBow;
    [FieldOffset(46)] public bool @shield;
    [FieldOffset(47)] public bool @wand;
    [FieldOffset(48)] public bool @weapon1H_mainHand;
    [FieldOffset(49)] public bool @weapon1H_offHand;
    [FieldOffset(50)] public bool @weapon2H;
    [FieldOffset(51)] public bool @weapon2L;
}

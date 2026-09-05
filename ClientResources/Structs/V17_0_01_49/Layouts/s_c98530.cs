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

[SerializedExtent(96)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c98530
{
    [FieldOffset(8, ArrayStride = 20)] public Layouts.@s_c98630[] @complexAnimations;
    [FieldOffset(40)] public ResourcePointer @playOnMount;
    [FieldOffset(48)] public ResourcePointer @playOnRider;
    [FieldOffset(56)] public ResourcePointer @playOnRiderTopOnly;
    [FieldOffset(64, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @visualDismount;
}

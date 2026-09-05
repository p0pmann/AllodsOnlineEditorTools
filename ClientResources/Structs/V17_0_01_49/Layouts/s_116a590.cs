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

[SerializedExtent(112)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_116a590
{
    [FieldOffset(8, ArrayStride = 8)] public NullablePointer[] @avatarPredicates;
    [FieldOffset(40)] public NullablePointer @item;
    [FieldOffset(48, ArrayStride = 16)] public Layouts.@s_f69650[] @requiredAchievements;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @requiredUnlocks;
}

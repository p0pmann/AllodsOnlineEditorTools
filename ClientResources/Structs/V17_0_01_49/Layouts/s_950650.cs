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

[SerializedExtent(88)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_950650
{
    [FieldOffset(8)] public ResourcePointer @defaultItemClass;
    [FieldOffset(16)] public ResourcePointer @defaultItemQuality;
    [FieldOffset(24, ArrayStride = 40)] public Layouts.@s_950840[] @itemClasses;
    [FieldOffset(56, ArrayStride = 40)] public Layouts.@s_950840[] @itemQualities;
}

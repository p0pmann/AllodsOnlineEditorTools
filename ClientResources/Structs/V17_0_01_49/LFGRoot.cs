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

[StructSize(328)]
[XdbName("avatarPopulation.service.impl.lookingForGroupImpl.scheme.LFGRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LFGRoot
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @additionalPredicates;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @damagerClasses;
    [FieldOffset(104, ArrayStride = 8)] public NullablePointer[] @departPredicates;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @destinations;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @healerClasses;
    [FieldOffset(200, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(232, ArrayStride = 12)] public Layouts.@s_1031c50[] @roleSettings;
    [FieldOffset(264, ArrayStride = 4)] public Layouts.@s_163010[] @spellGroups;
    [FieldOffset(296, ArrayStride = 8)] public ResourcePointer[] @tankClasses;
}

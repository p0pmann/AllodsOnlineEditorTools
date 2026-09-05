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

[StructSize(264)]
[XdbName("avatarPopulation.service.impl.matchMakingImpl.scheme.MatchMakingRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MatchMakingRoot
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @categoriesViewOrder;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_150f990[] @damageDealerClasses;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @events;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @eventsCommon;
    [FieldOffset(168, ArrayStride = 48)] public Layouts.@s_150f990[] @healerClasses;
    [FieldOffset(200, ArrayStride = 8)] public NullablePointer[] @joinPredicates;
    [FieldOffset(232, ArrayStride = 48)] public Layouts.@s_150f990[] @tankClasses;
}

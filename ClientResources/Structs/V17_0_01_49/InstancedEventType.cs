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

[SerializedExtent(64)]
[XdbName("avatarPopulation.service.impl.matchMakingImpl.scheme.InstancedEventType")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InstancedEventType
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_115c100))] public int @unionType;
    [FieldOffset(40)] public int @minAvatarsCount;
    [FieldOffset(48)] public NullablePointer @minAvatarLevel;
    [FieldOffset(56)] public float @immediatelyStartFactor;
    [FieldOffset(60)] public int @capacity;
}

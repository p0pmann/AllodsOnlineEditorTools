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

[StructSize(56)]
[XdbName("avatarPopulation.service.impl.matchMakingImpl.scheme.MWarMatchMakingRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MWarMatchMakingRoot
{
    [FieldOffset(40)] public ResourcePointer @groupEventResource;
    [FieldOffset(48)] public ResourcePointer @raidEventResource;
}

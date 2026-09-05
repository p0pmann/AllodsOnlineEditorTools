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

[SerializedExtent(56)]
[XdbName("avatarPopulation.service.impl.lookingForGroupImpl.elements.PredicateLFGRole")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateLFGRole
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_110fa30))] public int @role;
}

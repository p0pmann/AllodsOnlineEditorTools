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

[SerializedExtent(77)]
[XdbName("gameMechanics.elements.resources.ResourceBuff")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceBuff
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(64)] public ResourcePointer @buff;
    [FieldOffset(72)] public int @consumeStacks;
    [FieldOffset(76)] public bool @anyRank;
}

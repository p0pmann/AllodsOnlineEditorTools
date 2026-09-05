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

[SerializedExtent(101)]
[XdbName("CreatureClientPetVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureClientPetVisAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)] public float @maxDistance;
    [FieldOffset(72)] public float @minDistance;
    [FieldOffset(80)] public ResourcePointer @petInfo;
    [FieldOffset(88)] public float @runSpeed;
    [FieldOffset(92)] public float @teleportDistance;
    [FieldOffset(96)] public float @walkSpeed;
    [FieldOffset(100)] public bool @hideWhenOnMount;
}

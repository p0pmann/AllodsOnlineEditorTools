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

[SerializedExtent(192)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17db320
{
    [FieldOffset(8, ArrayStride = 8)] public ResourcePointer[] @collectionEditions;
    [FieldOffset(40)] public string @groupName;
    [FieldOffset(64)] public Layouts.@s_17d9f00 @guildMember;
    [FieldOffset(112)] public Vector3 @offset;
    [FieldOffset(128)] public string @scriptID;
    [FieldOffset(152)] public string @transportID;
    [FieldOffset(176)] public ResourcePointer @visualMob;
    [FieldOffset(184)] public float @yaw;
    [FieldOffset(188)] public bool @isDead;
    [FieldOffset(189)] public bool @isDisableToRotate;
    [FieldOffset(190)] public bool @notCreateAvatarReplicatedParts;
    [FieldOffset(191)] public bool @useGlobal;
}

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

[StructSize(168)]
[XdbName("gameMechanics.world.projectile.ProjectileResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ProjectileResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(76)] public float @corpulence;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112)] public NullablePointer @spawnLocation;
    [FieldOffset(120)] public bool @manualCorpulence;
    [FieldOffset(132)] public float @altitude;
    [FieldOffset(136)] public ResourcePointer @visForEnemy;
    [FieldOffset(144)] public ResourcePointer @visForFriend;
    [FieldOffset(152)] public ResourcePointer @visObject;
    [FieldOffset(160)] public bool @checkTransportCollision;
    [FieldOffset(161)] public bool @dontFade;
}

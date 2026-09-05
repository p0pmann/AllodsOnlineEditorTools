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

[StructSize(80)]
[XdbName("Collision")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Collision
{
    [FieldOffset(36)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(64)] public ResourcePointer @collisionMesh;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_236410))] public int @volume;
    [FieldOffset(76)] public bool @hasVisualCollision;
}

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

[StructSize(248)]
[XdbName("gameMechanics.world.ship.VisualShip")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualShip
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_1628900))] public int @cannonVisualType;
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @compatibleSkins;
    [FieldOffset(72)] public ResourcePointer @defaultSkin;
    [FieldOffset(80)] public TextFileRef @description;
    [FieldOffset(112)] public ResourcePointer @image;
    [FieldOffset(120)] public TextFileRef @name;
    [FieldOffset(152, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(184)] public float @radius;
    [FieldOffset(192, ArrayStride = 120)] public Layouts.@s_15fd070[] @slots;
    [FieldOffset(224)] public ResourcePointer @steeringParams;
    [FieldOffset(232)] public ResourcePointer @transportVisObject;
    [FieldOffset(240)] public ResourcePointer @unlock;
}

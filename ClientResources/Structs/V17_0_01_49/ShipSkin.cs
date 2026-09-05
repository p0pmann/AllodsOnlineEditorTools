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

[StructSize(216)]
[XdbName("gameMechanics.world.ship.ShipSkin")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipSkin
{
    [FieldOffset(40)] public Layouts.@s_15693a0 @customization;
    [FieldOffset(80)] public ResourcePointer @defaultItem;
    [FieldOffset(88)] public TextFileRef @description;
    [FieldOffset(120)] public ResourcePointer @image;
    [FieldOffset(128)] public ResourcePointer @interiorVisObject;
    [FieldOffset(136)] public TextFileRef @name;
    [FieldOffset(168, ArrayStride = 8)] public NullablePointer[] @parts;
    [FieldOffset(200)] public ResourcePointer @staticObj;
    [FieldOffset(208)] public ResourcePointer @unlock;
}

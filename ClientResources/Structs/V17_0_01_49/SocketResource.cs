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
[XdbName("gameMechanics.constructor.schemes.item.gem.SocketResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SocketResource
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_1000720))] public int @gemSlot;
    [FieldOffset(40)] public NullablePointer @moveToCondition;
    [FieldOffset(48)] public ResourcePointer @quality;
}

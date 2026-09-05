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

[StructSize(64)]
[XdbName("gameMechanics.world.ClientData")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ClientData
{
    [FieldOffset(40)] public NullablePointer @customData;
    [FieldOffset(48)] public NullablePointer @params;
    [FieldOffset(56)] public NullablePointer @visEventData;
}

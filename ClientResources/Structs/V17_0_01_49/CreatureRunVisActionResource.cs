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

[SerializedExtent(88)]
[XdbName("CreatureRunVisActionResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureRunVisActionResource
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public ResourcePointer @alias;
    [FieldOffset(80)] public ResourcePointer @resource;
}

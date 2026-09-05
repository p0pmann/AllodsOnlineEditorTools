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

[StructSize(144)]
[XdbName("InterfaceMapMarker")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceMapMarker
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public TextFileRef @name;
    [FieldOffset(104)] public int @priority;
    [FieldOffset(112)] public string @sysUIScriptName;
    [FieldOffset(136)] public ResourcePointer @texture;
}

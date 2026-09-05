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

[SerializedExtent(148)]
[XdbName("InterfaceShowImage")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceShowImage
{
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public string @sysId;
    [FieldOffset(144)] public int @timeout;
}

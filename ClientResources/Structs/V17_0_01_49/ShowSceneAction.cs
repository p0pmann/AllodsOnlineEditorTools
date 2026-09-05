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

[SerializedExtent(97)]
[XdbName("ShowSceneAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShowSceneAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public ResourcePointer @scene;
    [FieldOffset(88)] public ResourcePointer @script;
    [FieldOffset(96)] public bool @destroyImmediately;
}

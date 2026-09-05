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

[SerializedExtent(129)]
[XdbName("InterfaceAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceAction
{
    [FieldOffset(48)] public string @sysChatChannel;
    [FieldOffset(72)] public string @sysId;
    [FieldOffset(96)] public TextFileRef @text;
    [FieldOffset(128)] public bool @holdInCombat;
}

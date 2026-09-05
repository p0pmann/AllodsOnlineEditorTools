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

[SerializedExtent(104)]
[XdbName("CreatureIfFlagVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureIfFlagVisAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public NullablePointer @visScriptEnd;
    [FieldOffset(80)] public NullablePointer @visScriptLoop;
    [FieldOffset(88)] public NullablePointer @visScriptStart;
    [FieldOffset(96)] public ResourcePointer @visualFlag;
}

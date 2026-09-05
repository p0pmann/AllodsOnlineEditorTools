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

[SerializedExtent(81)]
[XdbName("VICHideAttachedObj")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICHideAttachedObj
{
    [FieldOffset(48)] public ResourcePointer @attachedObj;
    [FieldOffset(56)] public string @locatorName;
    [FieldOffset(80)] public bool @hideEachFrame;
}

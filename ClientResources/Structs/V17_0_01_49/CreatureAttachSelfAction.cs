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

[SerializedExtent(169)]
[XdbName("CreatureAttachSelfAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureAttachSelfAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_176f700))] public int @attachTo;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96, ArrayStride = 24)] public string[] @memberLocatorName;
    [FieldOffset(128)] public NullablePointer @playAttachTo;
    [FieldOffset(136)] public NullablePointer @playAttachToWhenStopped;
    [FieldOffset(144)] public NullablePointer @playAttachToWhenStoppedBackground;
    [FieldOffset(152)] public NullablePointer @playOnSelf;
    [FieldOffset(160)] public NullablePointer @playOnSelfWhenStopped;
    [FieldOffset(168)] public bool @notifyCamera;
}

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

[SerializedExtent(134)]
[XdbName("CameraAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CameraAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_168610))] public int @anim;
    [FieldOffset(72)] public Vector3 @offset;
    [FieldOffset(84)] public int @playTimeMs;
    [FieldOffset(88)] public string @slotName;
    [FieldOffset(112)] public int @startTimeMs;
    [FieldOffset(120)] public ResourcePointer @visObj;
    [FieldOffset(128)] public int @yaw;
    [FieldOffset(132)] public bool @isForMainAvatarOnly;
    [FieldOffset(133)] public bool @isTargetRelated;
}

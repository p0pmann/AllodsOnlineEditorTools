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

[SerializedExtent(150)]
[XdbName("AttachedVisObjectComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AttachedVisObjectComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96)] public Vector3 @offset;
    [FieldOffset(108)] public int @priority;
    [FieldOffset(112)] public Quaternion @rotation;
    [FieldOffset(128)] public float @scale;
    [FieldOffset(136)] public ResourcePointer @visObject;
    [FieldOffset(144)] public bool @hideWithParentWhenNotAttached;
    [FieldOffset(145)] public bool @isPortraitEnabled;
    [FieldOffset(146)] public bool @lockScale;
    [FieldOffset(147)] public bool @scaleFromGlobal;
    [FieldOffset(148)] public bool @skipSound;
    [FieldOffset(149)] public bool @useLocator;
}

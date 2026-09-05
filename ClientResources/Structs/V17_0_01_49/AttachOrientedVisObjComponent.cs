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

[SerializedExtent(130)]
[XdbName("AttachOrientedVisObjComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AttachOrientedVisObjComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public string @locatorName;
    [FieldOffset(96)] public Vector3 @offset;
    [FieldOffset(108)][EnumRef(typeof(Enums.@e_bbde20))] public int @orientMode;
    [FieldOffset(112)] public float @scale;
    [FieldOffset(120)] public ResourcePointer @visObject;
    [FieldOffset(128)] public bool @isPortraitEnabled;
    [FieldOffset(129)] public bool @scaleFromGlobal;
}

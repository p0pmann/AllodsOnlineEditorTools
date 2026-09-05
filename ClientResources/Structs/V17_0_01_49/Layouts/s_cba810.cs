// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(44)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cba810
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_168610))] public int @animation;
    [FieldOffset(8)] public int @animationTime;
    [FieldOffset(12)] public Vector3 @cameraAnchor;
    [FieldOffset(24)] public Quaternion @cameraRotation;
    [FieldOffset(40)] public float @projSettingsVWidth;
}

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

[SerializedExtent(124)]
[XdbName("LightComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LightComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public float @attenuationPower;
    [FieldOffset(72)] public Vector3 @direction;
    [FieldOffset(88)] public ResourcePointer @editorVisObj;
    [FieldOffset(96)] public float @facingValue;
    [FieldOffset(100)] public float @intensity;
    [FieldOffset(104)] public float @intensityRandom;
    [FieldOffset(108)] public Vector3 @pivot;
    [FieldOffset(120)] public float @radius;
}

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

[SerializedExtent(64)]
[XdbName("PointLitMaterialParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PointLitMaterialParams
{
    [FieldOffset(44)] public int @ambientColor;
    [FieldOffset(48)] public int @pointLightColor;
    [FieldOffset(52)] public Vector3 @pointLightPosition;
}

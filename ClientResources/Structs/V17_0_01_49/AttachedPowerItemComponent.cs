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

[SerializedExtent(204)]
[XdbName("AttachedPowerItemComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AttachedPowerItemComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public ResourcePointer @defalutVisObj;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @grades;
    [FieldOffset(112)] public string @locatorName;
    [FieldOffset(136)] public Vector3 @offset;
    [FieldOffset(152, ArrayStride = 24)] public Layouts.@s_c511a0[] @replacements;
    [FieldOffset(184)] public Quaternion @rotation;
    [FieldOffset(200)] public float @scale;
}

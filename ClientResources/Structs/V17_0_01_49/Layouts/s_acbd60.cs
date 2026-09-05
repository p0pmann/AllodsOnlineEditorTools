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

[SerializedExtent(24)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_acbd60
{
    [FieldOffset(4)][EnumRef(typeof(Enums.@e_acc0a0))] public int @blendType;
    [FieldOffset(8)] public ResourcePointer @diffuseTexture;
    [FieldOffset(16)] public float @scaleU;
    [FieldOffset(20)] public float @scaleV;
}

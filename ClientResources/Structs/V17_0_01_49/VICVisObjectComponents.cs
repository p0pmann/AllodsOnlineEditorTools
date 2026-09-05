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

[SerializedExtent(88)]
[XdbName("VICVisObjectComponents")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICVisObjectComponents
{
    [FieldOffset(52)][EnumRef(typeof(Enums.@e_d13b10))] public int @target;
    [FieldOffset(56, ArrayStride = 8)] public NullablePointer[] @visObjComponents;
}

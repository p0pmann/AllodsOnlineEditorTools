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

[SerializedExtent(52)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cb6940
{
    [FieldOffset(8, ArrayStride = 48)] public Layouts.@s_cb66d0[] @bones;
    [FieldOffset(40)][EnumRef(typeof(Enums.@e_c63a70))] public int @controlName;
    [FieldOffset(44)] public float @maxVal;
    [FieldOffset(48)] public float @minVal;
}

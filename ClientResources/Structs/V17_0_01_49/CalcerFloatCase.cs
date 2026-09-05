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
[XdbName("gameMechanics.elements.calcers.CalcerFloatCase")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CalcerFloatCase
{
    [FieldOffset(48, ArrayStride = 48)] public Layouts.@s_f9a180[] @cases;
    [FieldOffset(80)] public NullablePointer @defaultCalcer;
}

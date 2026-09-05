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
[XdbName("gameMechanics.elements.calcers.CalcerLongDiv")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CalcerLongDiv
{
    [FieldOffset(48)] public NullablePointer @dividend;
    [FieldOffset(56)] public NullablePointer @divisor;
}

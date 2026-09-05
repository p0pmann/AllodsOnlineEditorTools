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
[XdbName("gameMechanics.elements.scalers.ScalerCase")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ScalerCase
{
    [FieldOffset(48, ArrayStride = 56)] public Layouts.@s_10c59a0[] @cases;
    [FieldOffset(80)] public NullablePointer @defaultScaler;
}

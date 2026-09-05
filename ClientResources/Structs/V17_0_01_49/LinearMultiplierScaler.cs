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

[SerializedExtent(92)]
[XdbName("gameMechanics.elements.scalers.LinearMultiplierScaler")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LinearMultiplierScaler
{
    [FieldOffset(48)] public Layouts.@s_1448d90 @additionalMultiplier;
    [FieldOffset(72)] public float @mul;
    [FieldOffset(80)] public NullablePointer @mulCalcer;
    [FieldOffset(88)] public float @sum;
}

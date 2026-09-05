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
[XdbName("gameMechanics.elements.scalers.RandomScaler")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RandomScaler
{
    [FieldOffset(48, EmbeddedVirtual = true)] public @RangeInt @range;
}

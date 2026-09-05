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

[SerializedExtent(108)]
[XdbName("gameMechanics.elements.predicates.PredicateAltCurrencyRange")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateAltCurrencyRange
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(56)] public ResourcePointer @currency;
    [FieldOffset(64, EmbeddedVirtual = true)] public @RangeInt @range;
}

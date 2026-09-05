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

[SerializedExtent(72)]
[XdbName("gameMechanics.constructor.schemes.item.calcers.ItemCalcerIf")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemCalcerIf
{
    [FieldOffset(48)] public NullablePointer @calcerElse;
    [FieldOffset(56)] public NullablePointer @calcerIf;
    [FieldOffset(64)] public NullablePointer @predicate;
}

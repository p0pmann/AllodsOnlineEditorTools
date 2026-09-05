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

[SerializedExtent(96)]
[XdbName("VICSelectComponentByGuildCurrency")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICSelectComponentByGuildCurrency
{
    [FieldOffset(48, ArrayStride = 80)] public Layouts.@s_d1b040[] @cases;
    [FieldOffset(88)] public ResourcePointer @currency;
}

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

[SerializedExtent(80)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_fdb5b0
{
    [FieldOffset(8, ArrayStride = 16)] public Layouts.@s_fd9aa0[] @altCurrencies;
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_fd9bd0[] @components;
    [FieldOffset(72)] public NullablePointer @moneyRequired;
}

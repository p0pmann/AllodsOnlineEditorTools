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

[StructSize(112)]
[XdbName("DeveloperAddonGroup")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeveloperAddonGroup
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_4dcea0[] @addonEntries;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_4dcea0[] @addonEntriesExcluded;
    [FieldOffset(104)] public int @timeout;
    [FieldOffset(108)] public bool @randomRunOrder;
}

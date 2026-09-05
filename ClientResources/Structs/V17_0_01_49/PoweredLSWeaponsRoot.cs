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
[XdbName("PoweredLSWeaponsRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PoweredLSWeaponsRoot
{
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_56cf10[] @powerItemReplacements;
    [FieldOffset(72)] public ResourcePointer @powerRule;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @powerRuleItems;
}

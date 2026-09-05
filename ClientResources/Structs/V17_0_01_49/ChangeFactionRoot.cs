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

[StructSize(104)]
[XdbName("itemService.basicElements.ChangeFactionRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ChangeFactionRoot
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_fbb1f0[] @pridenFactionChoices;
    [FieldOffset(72)] public ResourcePointer @spellDonateToEmpire;
    [FieldOffset(80)] public ResourcePointer @spellDonateToLeague;
    [FieldOffset(88)] public ResourcePointer @spellPridenToEmpire;
    [FieldOffset(96)] public ResourcePointer @spellPridenToLeague;
}

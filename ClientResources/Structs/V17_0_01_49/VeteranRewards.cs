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

[StructSize(80)]
[XdbName("itemService.elements.veteran.VeteranRewards")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VeteranRewards
{
    [FieldOffset(40)] public ResourcePointer @counter;
    [FieldOffset(48, ArrayStride = 24)] public Layouts.@s_577600[] @rewardEntries;
}

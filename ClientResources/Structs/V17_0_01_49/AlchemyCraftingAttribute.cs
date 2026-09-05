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

[SerializedExtent(121)]
[XdbName("gameMechanics.elements.skills.alchemy.AlchemyCraftingAttribute")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AlchemyCraftingAttribute
{
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @skills;
    [FieldOffset(88, ArrayStride = 8)] public ResourcePointer[] @properties;
    [FieldOffset(120)] public bool @joker;
}

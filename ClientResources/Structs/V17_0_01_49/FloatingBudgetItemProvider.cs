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

[SerializedExtent(84)]
[XdbName("gameMechanics.constructor.schemes.item.FloatingBudgetItemProvider")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @FloatingBudgetItemProvider
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_102e650))] public int @itemSpecialFeature;
    [FieldOffset(48)] public ResourcePointer @namer;
    [FieldOffset(56)] public ResourcePointer @resource;
    [FieldOffset(64)] public ResourcePointer @suffix;
    [FieldOffset(72)] public int @defenceMod;
    [FieldOffset(76)] public int @mainBudgetMod;
    [FieldOffset(80)] public int @offenceMod;
}

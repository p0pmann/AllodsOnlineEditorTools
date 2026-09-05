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

[StructSize(136)]
[XdbName("gameMechanics.constructor.schemes.item.RuneRegistry")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RuneRegistry
{
    [FieldOffset(36)] public int @baseCrystalCrumbs;
    [FieldOffset(40)] public int @baseGoldDust;
    [FieldOffset(48)] public ResourcePointer @crystalCrumb;
    [FieldOffset(56)] public ResourcePointer @goldDust;
    [FieldOffset(64)] public int @maxRuneLevel;
    [FieldOffset(72, ArrayStride = 24)] public Layouts.@s_14392e0[] @runeSlots;
    [FieldOffset(104, ArrayStride = 48)] public Layouts.@s_14393c0[] @runes;
}

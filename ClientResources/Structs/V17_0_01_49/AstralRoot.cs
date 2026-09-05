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

[StructSize(264)]
[XdbName("gameMechanics.world.gameRoot.AstralRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralRoot
{
    [FieldOffset(40)] public Layouts.@s_a96bc0 @abordageMusic;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @astralHubTemplates;
    [FieldOffset(112)] public ResourcePointer @graphResource;
    [FieldOffset(120, ArrayStride = 8)] public ResourcePointer[] @hangarZones;
    [FieldOffset(152, ArrayStride = 8)] public ResourcePointer[] @islandTemplates;
    [FieldOffset(184, ArrayStride = 48)] public Layouts.@s_158be20[] @music;
    [FieldOffset(216, ArrayStride = 8)] public ResourcePointer[] @stripeTextures;
    [FieldOffset(248)] public int @taLevelUpdatePeriodsCount;
    [FieldOffset(256)] public ResourcePointer @unlockResource;
}

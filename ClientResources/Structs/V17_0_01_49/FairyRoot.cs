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

[StructSize(120)]
[XdbName("gameMechanics.world.gameRoot.FairyRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @FairyRoot
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_157a1b0[] @drGroups;
    [FieldOffset(104)] public ResourcePointer @fairySpellsGroup;
    [FieldOffset(112)] public ResourcePointer @permanentFairySatiationKey;
}

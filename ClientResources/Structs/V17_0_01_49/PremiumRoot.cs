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
[XdbName("gameMechanics.world.gameRoot.PremiumRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PremiumRoot
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @defaultStages;
    [FieldOffset(72, ArrayStride = 104)] public Layouts.@s_10a3c90[] @smiles;
    [FieldOffset(104, ArrayStride = 48)] public Layouts.@s_10a3db0[] @territoryStages;
}

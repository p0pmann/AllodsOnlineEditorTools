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

[StructSize(64)]
[XdbName("gameMechanics.world.bigAstral.TierLevel")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TierLevel
{
    [FieldOffset(40)] public ResourcePointer @parent;
    [FieldOffset(48)] public ResourcePointer @quality;
    [FieldOffset(56)] public float @requiredUnlock;
    [FieldOffset(60)] public int @techLevel;
}

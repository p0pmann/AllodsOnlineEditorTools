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

[StructSize(176)]
[XdbName("gameMechanics.constructor.schemes.mount.MountTalentAbility")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MountTalentAbility
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @conflictGroups;
    [FieldOffset(72)] public int @price;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @talentGroups;
    [FieldOffset(112)] public ResourcePointer @unlock;
    [FieldOffset(120, ArrayStride = 8)] public ResourcePointer[] @unlockItems;
    [FieldOffset(152)] public bool @hideUntilUnlocked;
    [FieldOffset(168)] public ResourcePointer @ability;
}

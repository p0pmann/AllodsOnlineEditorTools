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

[SerializedExtent(164)]
[XdbName("VisCharTroop")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisCharTroop
{
    [FieldOffset(48)] public ResourcePointer @archiAnimationVisObj;
    [FieldOffset(56, ArrayStride = 48)] public Layouts.@s_c78250[] @archiAnimations;
    [FieldOffset(88)] public float @arvhMoveSpeed;
    [FieldOffset(92)] public float @defMoveSpeed;
    [FieldOffset(96, ArrayStride = 24)] public string[] @groupFxSlotNames;
    [FieldOffset(128, ArrayStride = 120)] public Layouts.@s_c78350[] @members;
    [FieldOffset(160)] public float @radius;
}

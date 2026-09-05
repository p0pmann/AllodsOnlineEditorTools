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

[SerializedExtent(148)]
[XdbName("CreatureTimeIntervalEndAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureTimeIntervalEndAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(76)][EnumRef(typeof(Enums.@e_1733130))] public int @channel;
    [FieldOffset(80)] public string @specialController;
    [FieldOffset(112, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(144)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
}

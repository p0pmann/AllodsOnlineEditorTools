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

[SerializedExtent(128)]
[XdbName("DeviceAnimationAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceAnimationAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(76)] public Layouts.@s_1787b00 @advanced;
    [FieldOffset(88, ArrayStride = 4)][EnumRef(typeof(Enums.@e_168610))] public int[] @animations;
    [FieldOffset(120)] public int @channelId;
    [FieldOffset(124)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
}

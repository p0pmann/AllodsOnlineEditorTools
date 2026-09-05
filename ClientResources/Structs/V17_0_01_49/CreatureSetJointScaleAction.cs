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

[SerializedExtent(104)]
[XdbName("CreatureSetJointScaleAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureSetJointScaleAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public string @jointName;
    [FieldOffset(96)] public float @jointScale;
    [FieldOffset(100)][EnumRef(typeof(Enums.@e_17124a0))] public int @useOn;
}

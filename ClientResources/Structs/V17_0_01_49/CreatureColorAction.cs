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

[SerializedExtent(109)]
[XdbName("CreatureColorAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureColorAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_17406b0))] public int @blendMode;
    [FieldOffset(72)] public Quaternion @colorFactor;
    [FieldOffset(88)] public int @colorValue;
    [FieldOffset(92)] public int @priority;
    [FieldOffset(96)] public float @timeOff;
    [FieldOffset(100)] public float @timeOn;
    [FieldOffset(104)][EnumRef(typeof(Enums.@e_17124a0))] public int @useOn;
    [FieldOffset(108)] public bool @ignoreDisable;
}

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

[SerializedExtent(92)]
[XdbName("ProceduralEffectVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ProceduralEffectVisAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)] public int @priority;
    [FieldOffset(72)] public ResourcePointer @proceduralEffect;
    [FieldOffset(80)] public float @timeOff;
    [FieldOffset(84)] public float @timeOn;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_17124a0))] public int @useOn;
}

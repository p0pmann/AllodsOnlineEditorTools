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

[SerializedExtent(85)]
[XdbName("LooterEmoteAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LooterEmoteAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_168610))] public int @animateEmote;
    [FieldOffset(72)] public float @fadeInTime;
    [FieldOffset(76)] public float @fadeOutTime;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_c4ebb0))] public int @mode;
    [FieldOffset(84)] public bool @playWhileLooting;
}

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

[SerializedExtent(51)]
[XdbName("IfAnimation")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @IfAnimation
{
    [FieldOffset(44)][EnumRef(typeof(Enums.@e_168610))] public int @anim;
    [FieldOffset(48)] public bool @checkMount;
    [FieldOffset(49)] public bool @checkNotPlaying;
    [FieldOffset(50)] public bool @checkTop;
}

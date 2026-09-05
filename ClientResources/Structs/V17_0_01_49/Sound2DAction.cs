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

[SerializedExtent(195)]
[XdbName("Sound2DAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Sound2DAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_177a2e0))] public int @actionType;
    [FieldOffset(72)] public float @musicSourceMaxRadius;
    [FieldOffset(80, ArrayStride = 24)] public Layouts.@s_a97800[] @musicSourceParameters;
    [FieldOffset(112)] public Layouts.@s_a96bc0 @reverbPreset;
    [FieldOffset(152)] public Layouts.@s_a96bc0 @sound;
    [FieldOffset(192)] public bool @forcedSoundStop;
    [FieldOffset(193)] public bool @onlyForMainAvatar;
    [FieldOffset(194)] public bool @resetGlobalParamsOnStop;
}

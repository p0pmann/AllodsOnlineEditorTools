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

[SerializedExtent(154)]
[XdbName("Sound3DAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Sound3DAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72)] public ResourcePointer @alias;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_17127b0))] public int @locator;
    [FieldOffset(88)] public string @locatorName;
    [FieldOffset(112)] public Layouts.@s_a96d80 @sound;
    [FieldOffset(152)] public bool @forcedSoundStop;
    [FieldOffset(153)] public bool @onlyForMainAvatar;
}

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

[SerializedExtent(121)]
[XdbName("Sound3DActionDevice")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Sound3DActionDevice
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80)] public Layouts.@s_a96d80 @sound;
    [FieldOffset(120)] public bool @forcedSoundStop;
}

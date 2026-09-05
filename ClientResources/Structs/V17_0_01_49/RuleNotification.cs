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

[StructSize(88)]
[XdbName("RuleNotification")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RuleNotification
{
    [FieldOffset(40)] public ResourcePointer @image;
    [FieldOffset(48)] public TextFileRef @text;
    [FieldOffset(80)][EnumRef(typeof(Enums.@e_120a2a0))] public int @type;
    [FieldOffset(84)] public bool @hideInactive;
}

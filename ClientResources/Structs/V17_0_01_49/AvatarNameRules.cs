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

[SerializedExtent(112)]
[XdbName("basement.server.lang.AvatarNameRules")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AvatarNameRules
{
    [FieldOffset(40)] public WString @matchUser;
    [FieldOffset(64)] public int @maxLength;
    [FieldOffset(68)] public int @minLength;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_a5bac0))] public int @transformation;
    [FieldOffset(88)] public WString @matchMaster;
}

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

[StructSize(360)]
[XdbName("ThirdPartySettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ThirdPartySettings
{
    [FieldOffset(40)] public Layouts.@s_331bc0 @discordSettings;
    [FieldOffset(160)] public TextFileRef @playerStatusInGroup;
    [FieldOffset(192)] public TextFileRef @playerStatusInQueue;
    [FieldOffset(224)] public TextFileRef @playerStatusInRaid;
    [FieldOffset(256)] public TextFileRef @playerStatusPartCharacterLevel;
    [FieldOffset(288)] public TextFileRef @playerStatusSelectCharacter;
    [FieldOffset(320)] public Layouts.@s_331f80 @ultralightSettings;
}

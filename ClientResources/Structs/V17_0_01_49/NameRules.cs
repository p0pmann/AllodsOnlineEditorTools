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

[StructSize(296)]
[XdbName("basement.server.lang.NameRules")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @NameRules
{
    [FieldOffset(40)] public TextFileRef @allowedLetters;
    [FieldOffset(72, EmbeddedVirtual = true)] public @AvatarNameRules @avatarNameRules;
    [FieldOffset(184)] public WString @country;
    [FieldOffset(208)] public NullablePointer @fatalityPhraseRules;
    [FieldOffset(216)] public NullablePointer @guildBossNameRules;
    [FieldOffset(224)] public NullablePointer @guildHallNameRules;
    [FieldOffset(232)] public NullablePointer @guildNameRules;
    [FieldOffset(240)] public WString @lang;
    [FieldOffset(264)] public WString @name;
    [FieldOffset(288)] public NullablePointer @shipNameRules;
}

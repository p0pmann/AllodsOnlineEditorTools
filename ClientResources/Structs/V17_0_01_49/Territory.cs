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

[StructSize(184)]
[XdbName("basement.server.config.Territory")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Territory
{
    [FieldOffset(40)] public string @FModSoundLanguage;
    [FieldOffset(64, ArrayStride = 24)] public string[] @allowedDomains;
    [FieldOffset(96)] public ResourcePointer @ingameSupport;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @languageRules;
    [FieldOffset(136)] public int @minimalAuctionNameLength;
    [FieldOffset(140)] public int @minimalRewardExchangeNameLength;
    [FieldOffset(144)] public ResourcePointer @parentTerritory;
    [FieldOffset(152)] public WString @shortName;
    [FieldOffset(176)] public bool @appendAccountIdToWishmasterLink;
    [FieldOffset(177)] public bool @disableCorpseThrowing;
    [FieldOffset(178)] public bool @ignoreAutoShard;
    [FieldOffset(179)] public bool @replaceFullDeniedWord;
    [FieldOffset(180)] public bool @showPvPMessageBox;
    [FieldOffset(181)] public bool @showRaitingInfo;
    [FieldOffset(182)] public bool @showZoneSelection;
}

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

[StructSize(608)]
[XdbName("UIGameRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIGameRoot
{
    [FieldOffset(40, ArrayStride = 40)] public FileRef[] @addonScriptBaseFileRefs;
    [FieldOffset(72)] public ResourcePointer @characterScenes;
    [FieldOffset(80)] public ResourcePointer @cursorTable;
    [FieldOffset(88)] public string @defaultFont;
    [FieldOffset(112)] public Layouts.@s_1c06e50 @defaultWidgetsSounds;
    [FieldOffset(136)] public ResourcePointer @fontAliases;
    [FieldOffset(144, ArrayStride = 72)] public Layouts.@s_1ba85e0[] @forms;
    [FieldOffset(176)] public ResourcePointer @lockedPlayerTemplate;
    [FieldOffset(184)] public float @lockedPlayerTemplateScale;
    [FieldOffset(192)] public ResourcePointer @mission;
    [FieldOffset(200)] public float @pickRangeBox;
    [FieldOffset(204)] public float @pickRangePrecise;
    [FieldOffset(208, ArrayStride = 12)] public Layouts.@s_1b99680[] @quantumScales;
    [FieldOffset(240)] public ResourcePointer @sheathHide;
    [FieldOffset(248)] public ResourcePointer @sheathShowMelee;
    [FieldOffset(256)] public ResourcePointer @sheathShowRanged;
    [FieldOffset(264)] public ResourcePointer @slonRoot;
    [FieldOffset(272, ArrayStride = 232)] public Layouts.@s_1b99840[] @soundParameters;
    [FieldOffset(304, ArrayStride = 8)] public ResourcePointer[] @states;
    [FieldOffset(336, ArrayStride = 8)] public ResourcePointer[] @styleSheets;
    [FieldOffset(368)] public ResourcePointer @systemSpec;
    [FieldOffset(376)] public ResourcePointer @textFiltersList;
    [FieldOffset(384)] public Layouts.@s_1bcad90 @textFormatInfo;
    [FieldOffset(520)] public ResourcePointer @uiBinds;
    [FieldOffset(528)] public ResourcePointer @uioptions;
    [FieldOffset(536)] public ResourcePointer @urls;
    [FieldOffset(544, ArrayStride = 40)] public FileRef[] @userAddonScriptBaseFileRefs;
    [FieldOffset(576, ArrayStride = 40)] public Layouts.@s_1ba87f0[] @widgets;
}

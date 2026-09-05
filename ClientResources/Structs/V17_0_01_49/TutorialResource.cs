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

[StructSize(344)]
[XdbName("TutorialResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TutorialResource
{
    [FieldOffset(40)] public NullablePointer @bind;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @excludeContentKeys;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @link;
    [FieldOffset(120)] public NullablePointer @maxLevel;
    [FieldOffset(128)] public NullablePointer @minLevel;
    [FieldOffset(136)] public TextFileRef @name;
    [FieldOffset(168)] public ResourcePointer @nextTutorial;
    [FieldOffset(176, ArrayStride = 64)] public Layouts.@s_5710e0[] @popUps;
    [FieldOffset(208, ArrayStride = 8)] public ResourcePointer[] @requiredContentKeys;
    [FieldOffset(240)] public int @runTimeout;
    [FieldOffset(244)][EnumRef(typeof(Enums.@e_573ee0))] public int @runType;
    [FieldOffset(248)] public TextFileRef @shortText;
    [FieldOffset(280)] public string @sysName;
    [FieldOffset(304)] public TextFileRef @text;
    [FieldOffset(336)][EnumRef(typeof(Enums.@e_574130))] public int @viewType;
    [FieldOffset(340)] public bool @isForced;
    [FieldOffset(341)] public bool @isUnlearnable;
}

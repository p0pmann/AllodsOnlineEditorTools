// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(697)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1601270
{
    [FieldOffset(48)] public Layouts.@s_151d4a0 @contextActionInfo;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @interruptsActionGroups;
    [FieldOffset(208)] public TextFileRef @Description;
    [FieldOffset(240)] public TextFileRef @Name;
    [FieldOffset(272)] public ResourcePointer @aeMarker;
    [FieldOffset(280)] public int @defaultAction;
    [FieldOffset(288, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(320)] public ResourcePointer @durationBuff;
    [FieldOffset(328)][EnumRef(typeof(Enums.@e_160d640))] public int @element;
    [FieldOffset(332)][EnumRef(typeof(Enums.@e_17202a0))] public int @iffPolicy;
    [FieldOffset(336)] public ResourcePointer @image;
    [FieldOffset(344)] public int @level;
    [FieldOffset(352)] public Layouts.@s_1606370 @mechanics;
    [FieldOffset(504)] public NullablePointer @minRange;
    [FieldOffset(512)] public NullablePointer @params;
    [FieldOffset(520)] public int @prepareDuration;
    [FieldOffset(528)] public NullablePointer @range;
    [FieldOffset(536, ArrayStride = 8)] public ResourcePointer[] @ranks;
    [FieldOffset(568)] public Layouts.@s_10a8a40 @relatedResources;
    [FieldOffset(640)] public string @sysName;
    [FieldOffset(664)][EnumRef(typeof(Enums.@e_1609f70))] public int @targetType;
    [FieldOffset(668)][EnumRef(typeof(Enums.@e_1601f90))] public int @uiSpellBookPageType;
    [FieldOffset(672)] public NullablePointer @useVisScipt;
    [FieldOffset(680)] public ResourcePointer @visualScripts;
    [FieldOffset(688)] public bool @autoAppendToActionPanel;
    [FieldOffset(689)] public bool @ignoreGlobalCooldown;
    [FieldOffset(690)] public bool @isExploit;
    [FieldOffset(691)] public bool @isHiddenAction;
    [FieldOffset(692)] public bool @isWorkOnDead;
    [FieldOffset(693)] public bool @launchWhenReady;
    [FieldOffset(694)] public bool @needInFront;
    [FieldOffset(695)] public bool @replaceLowRanks;
    [FieldOffset(696)] public bool @triggersGlobalCooldown;
}

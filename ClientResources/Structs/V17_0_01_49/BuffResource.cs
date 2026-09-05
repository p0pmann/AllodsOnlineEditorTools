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

[StructSize(480)]
[XdbName("gameMechanics.constructor.schemes.buff.BuffResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BuffResource
{
    [FieldOffset(48)] public TextFileRef @Description;
    [FieldOffset(80)] public TextFileRef @Name;
    [FieldOffset(112)] public NullablePointer @actionOnVisualChange;
    [FieldOffset(120, ArrayStride = 80)] public Layouts.@s_156c590[] @descVars;
    [FieldOffset(152, ArrayStride = 8)] public ResourcePointer[] @gainSpells;
    [FieldOffset(184, ArrayStride = 8)] public ResourcePointer[] @groups;
    [FieldOffset(216)] public ResourcePointer @image;
    [FieldOffset(224)][EnumRef(typeof(Enums.@e_11587c0))] public int @interfacePriority;
    [FieldOffset(232, ArrayStride = 8)] public ResourcePointer[] @ranks;
    [FieldOffset(264)] public TextFileRef @shortName;
    [FieldOffset(296)] public int @stackLimit;
    [FieldOffset(304)] public string @sysUIScriptName;
    [FieldOffset(328)] public ResourcePointer @visScript;
    [FieldOffset(336, ArrayStride = 176)] public Layouts.@s_1713b60[] @visualEffects;
    [FieldOffset(368, ArrayStride = 176)] public Layouts.@s_1713b60[] @visualEffectsDecCount;
    [FieldOffset(400, ArrayStride = 176)] public Layouts.@s_1713b60[] @visualEffectsIncCount;
    [FieldOffset(432, ArrayStride = 176)] public Layouts.@s_1713b60[] @visualPostEffects;
    [FieldOffset(464)] public bool @availableInUserAddons;
    [FieldOffset(465)] public bool @isDetachableOnWill;
    [FieldOffset(466)] public bool @isGradual;
    [FieldOffset(467)] public bool @isHelpful;
    [FieldOffset(468)] public bool @isMultiple;
    [FieldOffset(469)] public bool @isStackable;
    [FieldOffset(470)] public bool @needVisualize;
    [FieldOffset(471)] public bool @needVisualizeDuration;
    [FieldOffset(472)] public bool @onlyForTargetAndCaster;
    [FieldOffset(473)] public bool @restartOnVisualChange;
}

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

[StructSize(432)]
[XdbName("UIOption")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIOption
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_1be9850))] public int @dataType;
    [FieldOffset(40)] public int @defaultIndex;
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public TextFileRef @maxDescription;
    [FieldOffset(112)] public TextFileRef @maxName;
    [FieldOffset(144)] public float @maxRangeValue;
    [FieldOffset(152)] public TextFileRef @minDescription;
    [FieldOffset(184)] public TextFileRef @minName;
    [FieldOffset(216)] public float @minRangeValue;
    [FieldOffset(224)] public TextFileRef @name;
    [FieldOffset(256)] public string @sysCodeId;
    [FieldOffset(280)] public string @sysCustomId;
    [FieldOffset(304)] public string @sysCustomType;
    [FieldOffset(328)] public string @sysGlobalVarId;
    [FieldOffset(352)] public TextFileRef @useAttemptWarning;
    [FieldOffset(384)] public int @valueCount;
    [FieldOffset(392, ArrayStride = 80)] public Layouts.@s_1be4210[] @values;
    [FieldOffset(424)][EnumRef(typeof(Enums.@e_1bebc40))] public int @viewType;
    [FieldOffset(428)] public bool @isSendEvent;
    [FieldOffset(429)] public bool @needPreview;
    [FieldOffset(430)] public bool @restartToApply;
}

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

[StructSize(320)]
[XdbName("gameMechanics.elements.goals.GoalResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @GoalResource
{
    [FieldOffset(40)] public ResourcePointer @customFinishData;
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80, ArrayStride = 8)] public NullablePointer[] @finishPredicates;
    [FieldOffset(112, ArrayStride = 64)] public Layouts.@s_10468a0[] @locations;
    [FieldOffset(144, ArrayStride = 80)] public Layouts.@s_10469a0[] @rewards;
    [FieldOffset(176)] public TextFileRef @shortDescription;
    [FieldOffset(208, ArrayStride = 8)] public NullablePointer[] @showPredicates;
    [FieldOffset(240, ArrayStride = 8)] public ResourcePointer[] @stages;
    [FieldOffset(272)] public int @targetLevel;
    [FieldOffset(280)] public TextFileRef @title;
    [FieldOffset(312)] public bool @hideInQuestBook;
    [FieldOffset(313)] public bool @hideOnLoadingScreen;
    [FieldOffset(314)] public bool @isHideCompleted;
}

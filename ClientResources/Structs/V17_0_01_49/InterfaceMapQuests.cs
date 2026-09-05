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
[XdbName("InterfaceMapQuests")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @InterfaceMapQuests
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @lowQuests;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @lowQuestsEmpireOnly;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @lowQuestsLeagueOnly;
    [FieldOffset(136, ArrayStride = 8)] public ResourcePointer[] @lowQuestsPridenOnly;
    [FieldOffset(168, ArrayStride = 8)] public ResourcePointer[] @quests;
    [FieldOffset(200, ArrayStride = 8)] public ResourcePointer[] @questsEmpireOnly;
    [FieldOffset(232, ArrayStride = 8)] public ResourcePointer[] @questsLeagueOnly;
    [FieldOffset(264, ArrayStride = 8)] public ResourcePointer[] @questsPridenOnly;
}

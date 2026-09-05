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

[StructSize(72)]
[XdbName("buildTools.questHelper.DebugQuestList")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DebugQuestList
{
    [FieldOffset(40, ArrayStride = 144)] public Layouts.@s_4d56b0[] @quests;
}

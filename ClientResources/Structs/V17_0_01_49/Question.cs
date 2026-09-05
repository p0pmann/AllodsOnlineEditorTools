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
[XdbName("gameMechanics.world.quiz.Question")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Question
{
    [FieldOffset(40)] public NullablePointer @params;
    [FieldOffset(48)] public NullablePointer @questionCustomData;
    [FieldOffset(56)] public NullablePointer @result;
    [FieldOffset(64)][EnumRef(typeof(Enums.@e_11261c0))] public int @showResults;
}

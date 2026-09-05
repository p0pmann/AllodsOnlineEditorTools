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

[StructSize(176)]
[XdbName("gameMechanics.constructor.schemes.vote.VoteResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VoteResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @marker;
    [FieldOffset(80, ArrayStride = 80)] public Layouts.@s_116f190[] @questions;
    [FieldOffset(112, ArrayStride = 24)] public Layouts.@s_15aed00[] @reward;
    [FieldOffset(144)] public TextFileRef @title;
}

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

[StructSize(136)]
[XdbName("itemService.medal.MedalRankResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MedalRankResource
{
    [FieldOffset(40)] public long @completeProgress;
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public ResourcePointer @image;
    [FieldOffset(88)] public TextFileRef @name;
    [FieldOffset(120)] public NullablePointer @reward;
    [FieldOffset(128)] public int @score;
}

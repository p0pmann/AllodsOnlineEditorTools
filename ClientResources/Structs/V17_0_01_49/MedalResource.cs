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

[StructSize(160)]
[XdbName("itemService.medal.MedalResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MedalResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @hidePredicates;
    [FieldOffset(72)] public ResourcePointer @image;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @medalRanks;
    [FieldOffset(112)] public TextFileRef @name;
    [FieldOffset(144)] public NullablePointer @progressObserver;
    [FieldOffset(152)] public bool @canLink;
    [FieldOffset(153)] public bool @isHideWhileNotReceived;
    [FieldOffset(154)] public bool @obsolete;
}

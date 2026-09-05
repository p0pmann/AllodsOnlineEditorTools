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
[XdbName("itemService.loginEvent.LoginEventReward")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LoginEventReward
{
    [FieldOffset(40, ArrayStride = 8)] public ResourcePointer[] @bronze;
    [FieldOffset(72)] public int @bronzeCount;
    [FieldOffset(76)] public int @day;
    [FieldOffset(80, ArrayStride = 8)] public ResourcePointer[] @gold;
    [FieldOffset(112)] public int @goldCount;
    [FieldOffset(120, ArrayStride = 8)] public ResourcePointer[] @silver;
    [FieldOffset(152)] public int @silverCount;
    [FieldOffset(156)] public bool @ignoreLevelCap;
}

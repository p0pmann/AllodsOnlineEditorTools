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

[StructSize(80)]
[XdbName("itemService.elements.loginLottery.LoginLotteryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LoginLotteryResource
{
    [FieldOffset(40)] public ResourcePointer @comboCounter;
    [FieldOffset(48, ArrayStride = 64)] public Layouts.@s_11102e0[] @prizes;
}

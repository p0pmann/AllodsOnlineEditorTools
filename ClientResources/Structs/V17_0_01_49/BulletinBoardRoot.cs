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

[StructSize(104)]
[XdbName("avatarPopulation.service.bulletinboard.BulletinBoardRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @BulletinBoardRoot
{
    [FieldOffset(40)] public ResourcePointer @addAction;
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @postTypes;
    [FieldOffset(80)] public Layouts.@s_1433350 @premiumPostPrice;
}

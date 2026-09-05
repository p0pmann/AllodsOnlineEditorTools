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
[XdbName("itemService.loginEvent.LoginEventGoal")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LoginEventGoal
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72, ArrayStride = 64)] public Layouts.@s_10468a0[] @locations;
    [FieldOffset(104)] public TextFileRef @title;
}

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

[StructSize(128)]
[XdbName("UIBindSection")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIBindSection
{
    [FieldOffset(40, ArrayStride = 104)] public Layouts.@s_1bc4d50[] @binds;
    [FieldOffset(72)] public TextFileRef @name;
    [FieldOffset(104)] public string @sysName;
}

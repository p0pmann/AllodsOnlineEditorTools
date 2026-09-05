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

[StructSize(192)]
[XdbName("UIOptionBlock")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIOptionBlock
{
    [FieldOffset(40)] public Layouts.@s_1be9690 @common;
    [FieldOffset(160, ArrayStride = 8)] public ResourcePointer[] @options;
}

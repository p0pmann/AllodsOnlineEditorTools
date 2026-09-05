// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(40)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_106c910
{
    [FieldOffset(4)] public int @positions;
    [FieldOffset(8, ArrayStride = 32)] public Layouts.@s_106c860[] @prizes;
}

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

[SerializedExtent(144)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c81740
{
    [FieldOffset(8, ArrayStride = 32)] public Layouts.@s_c4c420[] @visObjectTemplates;
    [FieldOffset(48, ArrayStride = 24)] public Layouts.@s_c4c270[] @creatureVisActions;
    [FieldOffset(80, ArrayStride = 24)] public Layouts.@s_c80540[] @visualItems;
    [FieldOffset(112, ArrayStride = 24)] public Layouts.@s_c80540[] @visualMounts;
}

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

[SerializedExtent(88)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1ceb630
{
    [FieldOffset(8)] public WString @Comment;
    [FieldOffset(32, ArrayStride = 56)] public Layouts.@s_1ceb8c0[] @Items;
    [FieldOffset(64)] public WString @Name;
}

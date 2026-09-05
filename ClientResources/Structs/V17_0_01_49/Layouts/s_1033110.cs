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

[SerializedExtent(48)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_1033110
{
    [FieldOffset(8)] public ResourcePointer @group;
    [FieldOffset(16, ArrayStride = 72)] public Layouts.@s_1033230[] @spellEntries;
}

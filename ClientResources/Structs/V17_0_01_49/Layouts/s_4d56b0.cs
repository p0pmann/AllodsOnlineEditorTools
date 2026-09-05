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
public partial class @s_4d56b0
{
    [FieldOffset(8)] public WString @finisher;
    [FieldOffset(32)] public WString @follow;
    [FieldOffset(56)] public WString @giver;
    [FieldOffset(80)] public int @level;
    [FieldOffset(88, ArrayStride = 24)] public WString[] @line;
    [FieldOffset(120)] public WString @name;
}

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

[SerializedExtent(33)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17efd00
{
    [FieldOffset(8)] public ResourcePointer @fromAction;
    [FieldOffset(16)] public NullablePointer @script;
    [FieldOffset(24)] public ResourcePointer @toAction;
    [FieldOffset(32)] public bool @fromAny;
}

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

[SerializedExtent(56)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c69030
{
    [FieldOffset(8)] public string @filter;
    [FieldOffset(32)] public ResourcePointer @replacement;
    [FieldOffset(40)] public ResourcePointer @visCharacterTemplate;
    [FieldOffset(48)] public NullablePointer @visObjComponent;
}

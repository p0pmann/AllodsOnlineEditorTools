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

[SerializedExtent(97)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_67b7a0
{
    [FieldOffset(8)] public ResourcePointer @contentKey;
    [FieldOffset(16)][EnumRef(typeof(Enums.@e_11d5920))] public int @currencyId;
    [FieldOffset(24)] public TextFileRef @description;
    [FieldOffset(56)] public ResourcePointer @image;
    [FieldOffset(64)] public TextFileRef @name;
    [FieldOffset(96)] public bool @bindWarning;
}

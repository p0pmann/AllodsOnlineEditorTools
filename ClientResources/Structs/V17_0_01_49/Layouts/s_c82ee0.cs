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

[SerializedExtent(89)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_c82ee0
{
    [FieldOffset(8)] public ResourcePointer @armorScene;
    [FieldOffset(16)] public int @color;
    [FieldOffset(24)] public string @locatorName;
    [FieldOffset(48)] public int @maskColor;
    [FieldOffset(56)] public ResourcePointer @replacement;
    [FieldOffset(64)] public string @shapeName;
    [FieldOffset(88)] public bool @useCharacterShapeName;
}

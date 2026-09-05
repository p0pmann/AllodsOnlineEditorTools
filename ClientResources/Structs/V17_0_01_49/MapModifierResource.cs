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

[StructSize(128)]
[XdbName("gameMechanics.map.basicElements.MapModifierResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MapModifierResource
{
    [FieldOffset(48)] public TextFileRef @description;
    [FieldOffset(80)] public int @difficult;
    [FieldOffset(88)] public ResourcePointer @image;
    [FieldOffset(96)] public TextFileRef @name;
}

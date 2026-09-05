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

[SerializedExtent(29)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_10ab170
{
    [FieldOffset(8)] public ResourcePointer @image;
    [FieldOffset(16)] public ResourcePointer @item;
    [FieldOffset(24)][EnumRef(typeof(Enums.@e_10ab4a0))] public int @quality;
    [FieldOffset(28)] public bool @isImportant;
}

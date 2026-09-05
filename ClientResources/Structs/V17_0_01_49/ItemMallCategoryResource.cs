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

[StructSize(184)]
[XdbName("itemService.itemmall.resources.ItemMallCategoryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemMallCategoryResource
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72)] public ResourcePointer @image;
    [FieldOffset(80)] public TextFileRef @name;
    [FieldOffset(112, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(144)] public TextFileRef @publicName;
    [FieldOffset(176)][EnumRef(typeof(Enums.@e_159c400))] public int @type;
}

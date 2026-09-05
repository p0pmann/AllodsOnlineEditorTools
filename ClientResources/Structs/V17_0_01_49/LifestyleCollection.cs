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

[StructSize(168)]
[XdbName("LifestyleCollection")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @LifestyleCollection
{
    [FieldOffset(40)] public TextFileRef @description;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @items;
    [FieldOffset(104)] public TextFileRef @name;
    [FieldOffset(136, ArrayStride = 56)] public Layouts.@s_56a400[] @spells;
}

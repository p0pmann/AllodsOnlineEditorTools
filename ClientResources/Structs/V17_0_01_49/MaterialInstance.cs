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

[StructSize(112)]
[XdbName("MaterialInstance")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MaterialInstance
{
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_212950[] @colorVars;
    [FieldOffset(72)] public ResourcePointer @matTemplate;
    [FieldOffset(80, ArrayStride = 32)] public Layouts.@s_2129d0[] @switches;
}

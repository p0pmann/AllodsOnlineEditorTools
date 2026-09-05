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

[StructSize(80)]
[XdbName("UIRelatedResources")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UIRelatedResources
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_1b183f0[] @Items;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_1b18e60))] public int @mergePolicy;
}

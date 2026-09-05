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
[XdbName("CreatureVisState")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @CreatureVisState
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_168610))] public int @fixedIdleAnimation;
    [FieldOffset(40)] public float @scale;
    [FieldOffset(44)] public int @stateID;
    [FieldOffset(48, ArrayStride = 24)] public Layouts.@s_c5a7a0[] @transferScripts;
}

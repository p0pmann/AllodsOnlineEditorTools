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

[SerializedExtent(40)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_196ce10
{
    [FieldOffset(8)] public NullablePointer @casterFxScript;
    [FieldOffset(16)] public float @fadeDuration;
    [FieldOffset(20)] public float @fadeStartTime;
    [FieldOffset(24)] public NullablePointer @offenderDeathScript;
    [FieldOffset(32)] public float @sparkDelay;
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_18fd1b0))] public int @type;
}

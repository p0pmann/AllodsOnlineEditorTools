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

[SerializedExtent(92)]
[XdbName("VICApplyGuildTexture")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VICApplyGuildTexture
{
    [FieldOffset(56, ArrayStride = 24)] public string[] @shapeName;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_d13b10))] public int @target;
}

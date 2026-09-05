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

[SerializedExtent(145)]
[XdbName("Sound2DMatchAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Sound2DMatchAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(68)][EnumRef(typeof(Enums.@e_1139570))] public int @comparisonOperator;
    [FieldOffset(72)][EnumRef(typeof(Enums.@e_1139910))] public int @match;
    [FieldOffset(80)] public string @pattern;
    [FieldOffset(104)] public int @playingSoundsCount;
    [FieldOffset(112, ArrayStride = 48)] public Layouts.@s_1139520[] @sounds;
    [FieldOffset(144)] public bool @onlyForMainAvatar;
}

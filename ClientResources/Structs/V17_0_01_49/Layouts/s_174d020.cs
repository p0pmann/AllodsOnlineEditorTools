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

[SerializedExtent(38)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_174d020
{
    [FieldOffset(8)] public NullablePointer @allTimeScript;
    [FieldOffset(16)] public NullablePointer @enterFromBiggerScript;
    [FieldOffset(24)] public NullablePointer @enterFromLowerScript;
    [FieldOffset(32)] public float @maxValue;
    [FieldOffset(36)] public bool @playIfStateSkipedFromBigger;
    [FieldOffset(37)] public bool @playIfStateSkipedFromLower;
}

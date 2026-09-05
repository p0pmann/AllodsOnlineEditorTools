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

[SerializedExtent(132)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cb1ca0
{
    [FieldOffset(8)] public ResourcePointer @additionalVariation;
    [FieldOffset(16)] public ResourcePointer @face;
    [FieldOffset(24)] public ResourcePointer @facial;
    [FieldOffset(32)] public int @hairColor;
    [FieldOffset(40)] public ResourcePointer @hairGeoset;
    [FieldOffset(48)] public Layouts.@s_c64bc0 @morphPreset;
    [FieldOffset(96)] public int @morphPresetIndex;
    [FieldOffset(104)] public ResourcePointer @shoulderStone;
    [FieldOffset(112)] public int @shoulderStoneColor;
    [FieldOffset(120)] public ResourcePointer @skin;
    [FieldOffset(128)] public int @skinColor;
}

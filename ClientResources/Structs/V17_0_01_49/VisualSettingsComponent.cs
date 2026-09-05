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

[SerializedExtent(130)]
[XdbName("VisualSettingsComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualSettingsComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(68)] public float @fogFactor;
    [FieldOffset(72, ArrayStride = 24)] public Layouts.@s_bc3130[] @lods;
    [FieldOffset(104)] public Layouts.@s_bc31d0 @maxSettings;
    [FieldOffset(116)] public Layouts.@s_bc31d0 @minSettings;
    [FieldOffset(128)] public bool @lodsUniformScaling;
    [FieldOffset(129)] public bool @sizeIndependentFade;
}

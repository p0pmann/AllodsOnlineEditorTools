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

[StructSize(88)]
[XdbName("FlareEffect")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @FlareEffect
{
    [FieldOffset(36)] public float @fadeSpeed;
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_b64c40[] @flares;
    [FieldOffset(72)] public float @occlusionSize;
    [FieldOffset(76)] public float @sizeModifier;
    [FieldOffset(80)] public float @transparencyModifier;
    [FieldOffset(84)] public bool @visualOccluder;
}

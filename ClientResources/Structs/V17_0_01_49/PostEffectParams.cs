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

[StructSize(152)]
[XdbName("PostEffectParams")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PostEffectParams
{
    [FieldOffset(36)] public Layouts.@s_cdad20 @blurAddFactor;
    [FieldOffset(72)] public float @blurRadius;
    [FieldOffset(76)] public Layouts.@s_cdad20 @diffuseFactor;
    [FieldOffset(112)] public Layouts.@s_cdad20 @overlayFactor;
}

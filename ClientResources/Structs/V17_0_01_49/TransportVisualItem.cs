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

[StructSize(104)]
[XdbName("TransportVisualItem")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TransportVisualItem
{
    [FieldOffset(40, ArrayStride = 24)] public string[] @disabledGeosets;
    [FieldOffset(72, ArrayStride = 48)] public Layouts.@s_cce430[] @replacedTextures;
}

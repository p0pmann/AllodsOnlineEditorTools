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

[StructSize(136)]
[XdbName("TexturePatch")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TexturePatch
{
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_ca4780[] @female;
    [FieldOffset(72, ArrayStride = 32)] public Layouts.@s_ca4780[] @male;
    [FieldOffset(104, ArrayStride = 32)] public Layouts.@s_ca4780[] @unisex;
}

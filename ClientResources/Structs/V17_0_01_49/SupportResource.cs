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
[XdbName("basement.ingameSupport.SupportResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SupportResource
{
    [FieldOffset(40, ArrayStride = 48)] public Layouts.@s_122a750[] @components;
    [FieldOffset(72, ArrayStride = 72)] public Layouts.@s_122a570[] @sections;
}

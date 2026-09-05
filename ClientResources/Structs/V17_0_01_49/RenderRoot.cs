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

[StructSize(728)]
[XdbName("RenderRoot")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @RenderRoot
{
    [FieldOffset(40)] public ResourcePointer @material;
    [FieldOffset(48)] public Layouts.@s_20e030 @materialSettingsDX11;
    [FieldOffset(376)] public Layouts.@s_20e030 @materialSettingsDX9;
    [FieldOffset(704)] public ResourcePointer @meshLegacy;
    [FieldOffset(712)] public ResourcePointer @particleAtlas;
    [FieldOffset(720)] public ResourcePointer @userSurface;
}

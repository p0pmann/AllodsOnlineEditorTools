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

[SerializedExtent(136)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11c4f10
{
    [FieldOffset(8, ArrayStride = 24)] public Layouts.@s_11c53d0[] @devices;
    [FieldOffset(40)] public Layouts.@s_11e2060 @placement;
    [FieldOffset(88)] public string @scriptID;
    [FieldOffset(112)] public ResourcePointer @shipResource;
    [FieldOffset(120)] public ResourcePointer @shipSkin;
    [FieldOffset(128)] public ResourcePointer @visualShip;
}

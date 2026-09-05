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

[SerializedExtent(136)]
[XdbName("AstralHubObjectPart")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralHubObjectPart
{
    [FieldOffset(48)] public ResourcePointer @collisionIcon;
    [FieldOffset(56)] public float @collisionRadius;
    [FieldOffset(64)] public TextFileRef @description;
    [FieldOffset(96)] public ResourcePointer @image;
    [FieldOffset(104)] public TextFileRef @name;
}

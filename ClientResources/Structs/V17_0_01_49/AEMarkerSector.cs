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

[StructSize(80)]
[XdbName("AEMarkerSector")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AEMarkerSector
{
    [FieldOffset(44)] public float @angle;
    [FieldOffset(48)] public ResourcePointer @centerObj;
    [FieldOffset(56)] public ResourcePointer @fillerObj;
    [FieldOffset(64)] public ResourcePointer @leftObj;
    [FieldOffset(72)] public ResourcePointer @rightObj;
}

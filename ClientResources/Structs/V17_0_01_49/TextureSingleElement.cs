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

[StructSize(72)]
[XdbName("TextureSingleElement")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @TextureSingleElement
{
    [FieldOffset(40)] public ResourcePointer @atlas;
    [FieldOffset(48)] public int @height;
    [FieldOffset(56)] public ResourcePointer @key;
    [FieldOffset(64)] public int @sourceFileCRC;
    [FieldOffset(68)] public int @width;
}

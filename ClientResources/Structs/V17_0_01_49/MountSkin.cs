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

[StructSize(256)]
[XdbName("gameMechanics.constructor.schemes.mount.MountSkin")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @MountSkin
{
    [FieldOffset(40)] public TextFileRef @Description;
    [FieldOffset(72)] public TextFileRef @Name;
    [FieldOffset(104)] public TextFileRef @SourceDescription;
    [FieldOffset(136)] public ResourcePointer @alias;
    [FieldOffset(144)] public ResourcePointer @image;
    [FieldOffset(152, ArrayStride = 8)] public ResourcePointer[] @keys;
    [FieldOffset(184)] public TextFileRef @p2pSourceDescription;
    [FieldOffset(216)] public ResourcePointer @stallVisualMount;
    [FieldOffset(224)] public ResourcePointer @unlock;
    [FieldOffset(232)] public ResourcePointer @visualMount;
    [FieldOffset(240)] public NullablePointer @visualScript;
    [FieldOffset(248)] public bool @p2p;
}

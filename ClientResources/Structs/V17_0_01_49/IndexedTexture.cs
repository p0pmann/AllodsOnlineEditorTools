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

[StructSize(168)]
[XdbName("IndexedTexture")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @IndexedTexture
{
    [FieldOffset(40)] public FileRef @binaryFile;
    [FieldOffset(80)] public FileRef @binaryFile2;
    [FieldOffset(120)] public int @height;
    [FieldOffset(124)] public int @mipSW;
    [FieldOffset(128)] public int @mipsNumber;
    [FieldOffset(132)][EnumRef(typeof(Enums.@e_21cbd0))] public int @pool;
    [FieldOffset(136)] public int @realHeight;
    [FieldOffset(140)] public int @realWidth;
    [FieldOffset(144)][EnumRef(typeof(Enums.@e_221560))] public int @type;
    [FieldOffset(148)] public int @width;
    [FieldOffset(152)] public bool @alphaTex;
    [FieldOffset(153)] public bool @atlasPart;
    [FieldOffset(154)] public bool @disableLODControl;
    [FieldOffset(155)] public bool @generateMipChain;
    [FieldOffset(156)] public bool @isRealTimeLoading;
    [FieldOffset(157)] public bool @wrap;
}

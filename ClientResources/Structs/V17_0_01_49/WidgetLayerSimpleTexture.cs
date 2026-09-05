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
[XdbName("WidgetLayerSimpleTexture")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WidgetLayerSimpleTexture
{
    [FieldOffset(36)][EnumRef(typeof(Enums.@e_1cd7ac0))] public int @BlendEffect;
    [FieldOffset(40)] public int @Color;
    [FieldOffset(44)] public bool @Grayed;
    [FieldOffset(45)] public bool @flatPlacement;
    [FieldOffset(46)] public bool @lazyLoad;
    [FieldOffset(56)] public ResourcePointer @textureItem;
    [FieldOffset(64)] public ResourcePointer @textureMask;
    [FieldOffset(72)] public bool @Scaling;
}

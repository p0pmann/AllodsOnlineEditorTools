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

[StructSize(112)]
[XdbName("AstralObject")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @AstralObject
{
    [FieldOffset(36)] public float @astralRadius;
    [FieldOffset(40)] public Layouts.@s_cd1280 @effectFade;
    [FieldOffset(52)] public Layouts.@s_cd1280 @flareFade;
    [FieldOffset(64)] public ResourcePointer @flareTexture;
    [FieldOffset(72)] public float @forceFieldRadius;
    [FieldOffset(76)] public float @maxSize;
    [FieldOffset(80, ArrayStride = 24)] public Layouts.@s_cd1380[] @parts;
}

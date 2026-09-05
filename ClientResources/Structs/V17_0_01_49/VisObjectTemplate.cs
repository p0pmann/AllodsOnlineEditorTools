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

[StructSize(352)]
[XdbName("VisObjectTemplate")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisObjectTemplate
{
    [FieldOffset(40)] public Layouts.@s_bdc4d0 @defaultState;
    [FieldOffset(184)] public int @fadeInMS;
    [FieldOffset(188)] public int @fadeOutMS;
    [FieldOffset(192)] public ResourcePointer @geometry;
    [FieldOffset(200)] public ResourcePointer @particle;
    [FieldOffset(208)] public ResourcePointer @questHighlight;
    [FieldOffset(216)] public float @replaceDistance;
    [FieldOffset(224)] public ResourcePointer @replacement;
    [FieldOffset(232)] public float @scale;
    [FieldOffset(240)] public Layouts.@s_a96d80 @sound;
    [FieldOffset(280, ArrayStride = 144)] public Layouts.@s_bdc4d0[] @states;
    [FieldOffset(312, ArrayStride = 8)] public NullablePointer[] @visObjComponents;
    [FieldOffset(344)] public bool @drawBehindCamera;
    [FieldOffset(345)] public bool @softReplace;
    [FieldOffset(346)] public bool @useParticleBoundingBox;
}

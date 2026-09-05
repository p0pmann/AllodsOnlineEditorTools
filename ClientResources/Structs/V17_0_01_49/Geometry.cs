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

[StructSize(648)]
[XdbName("Geometry")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Geometry
{
    [FieldOffset(40)] public ResourcePointer @SkeletalAnimation;
    [FieldOffset(48)] public Layouts.@s_1828d0 @aabb;
    [FieldOffset(72, ArrayStride = 152)] public Layouts.@s_b685e0[] @areaFragments;
    [FieldOffset(104)] public ResourcePointer @attributeAnimation;
    [FieldOffset(112)] public FileRef @binaryFile;
    [FieldOffset(152)] public float @decalTraceHeight;
    [FieldOffset(156)] public float @fadeDistanceEnd;
    [FieldOffset(160)] public float @fadeDistanceStart;
    [FieldOffset(168, ArrayStride = 40)] public Layouts.@s_b683d0[] @flareInfos;
    [FieldOffset(200)] public float @fogFactor;
    [FieldOffset(204)] public Layouts.@s_1828d0 @geometryBox;
    [FieldOffset(232, ArrayStride = 40)] public Layouts.@s_b687b0[] @geometryFragments;
    [FieldOffset(264)] public int @globalID;
    [FieldOffset(268)][EnumRef(typeof(Enums.@e_b692f0))] public int @hideRule;
    [FieldOffset(272)] public Layouts.@s_2106e0 @indexBuffer;
    [FieldOffset(288, ArrayStride = 40)] public Layouts.@s_b68d10[] @joints;
    [FieldOffset(320, ArrayStride = 4)] public float[] @lodDistances;
    [FieldOffset(352)] public float @lodFactor;
    [FieldOffset(360, ArrayStride = 192)] public Layouts.@s_b76cf0[] @modelElements;
    [FieldOffset(392, ArrayStride = 60)] public Layouts.@s_b68ec0[] @occluderInfos;
    [FieldOffset(424)][EnumRef(typeof(Enums.@e_acb030))] public int @orientationMode;
    [FieldOffset(432, ArrayStride = 96)] public Layouts.@s_b68b60[] @parts;
    [FieldOffset(464, ArrayStride = 96)] public Layouts.@s_b68900[] @portalFragments;
    [FieldOffset(496)] public NullablePointer @rootMaterial;
    [FieldOffset(504)] public float @scaleDistanceEnd;
    [FieldOffset(508)] public float @scaleDistanceStart;
    [FieldOffset(512, ArrayStride = 64)] public Layouts.@s_b76eb0[] @sceneNodes;
    [FieldOffset(544)] public ResourcePointer @shadowSettings;
    [FieldOffset(552)] public Layouts.@s_2106e0 @skeleton;
    [FieldOffset(564)] public float @softFadeFactor;
    [FieldOffset(568)][EnumRef(typeof(Enums.@e_b69800))] public int @sortMode;
    [FieldOffset(572)] public int @version;
    [FieldOffset(576)] public Layouts.@s_2106e0 @vertexBuffer;
    [FieldOffset(592, ArrayStride = 116)] public Layouts.@s_b69140[] @vertexDeclarations;
    [FieldOffset(624)] public int @visualSkeletonSize;
    [FieldOffset(628)] public bool @absoluteDistanceFade;
    [FieldOffset(629)] public bool @castShadows;
    [FieldOffset(630)] public bool @checkVisibilityByGeometryBox;
    [FieldOffset(631)] public bool @decalModel;
    [FieldOffset(632)] public bool @enableDistanceFade;
    [FieldOffset(633)] public bool @exportDefaultAnimation;
    [FieldOffset(634)] public bool @fadeByCameraCollision;
    [FieldOffset(635)] public bool @ignoreFadeDistanceFactor;
    [FieldOffset(636)] public bool @ignoreZ;
    [FieldOffset(637)] public bool @largeModel;
    [FieldOffset(638)] public bool @lodModel;
    [FieldOffset(639)] public bool @portalModel;
    [FieldOffset(640)] public bool @useColors;
    [FieldOffset(641)] public bool @useDecals;
    [FieldOffset(642)] public bool @useProceduralEffect;
    [FieldOffset(643)] public bool @vb32;
}

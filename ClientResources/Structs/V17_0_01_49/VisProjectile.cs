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

[StructSize(152)]
[XdbName("VisProjectile")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisProjectile
{
    [FieldOffset(40)] public ResourcePointer @arrow;
    [FieldOffset(48)] public string @effectBone;
    [FieldOffset(72)] public ResourcePointer @effectFx;
    [FieldOffset(80)] public ResourcePointer @explosion;
    [FieldOffset(88)][EnumRef(typeof(Enums.@e_1718700))] public int @mainAxis;
    [FieldOffset(92)] public float @pointInTargetMax;
    [FieldOffset(96)] public float @pointInTargetMin;
    [FieldOffset(100)] public Layouts.@s_1713390 @rotation;
    [FieldOffset(120)] public string @trailBone;
    [FieldOffset(144)] public ResourcePointer @trailFx;
}

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
[XdbName("SunShafts")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SunShafts
{
    [FieldOffset(40, ArrayStride = 32)] public Layouts.@s_d3a290[] @effects;
    [FieldOffset(72)] public float @flarePivot;
    [FieldOffset(76)] public float @flarePoint0;
    [FieldOffset(80)] public float @flarePoint1;
    [FieldOffset(84)] public Layouts.@s_d38ca0 @flareScale;
    [FieldOffset(96)] public ResourcePointer @flareTexture;
    [FieldOffset(104)] public float @sPoint0;
    [FieldOffset(108)] public int @scrollTime;
    [FieldOffset(112)] public float @shaftPivot;
    [FieldOffset(120)] public ResourcePointer @shaftTexture;
    [FieldOffset(128)] public Layouts.@s_d38ca0 @shaftTransparency;
    [FieldOffset(140)] public float @shaftsPoint0;
    [FieldOffset(144)] public float @shaftsPoint1;
    [FieldOffset(148)] public float @shaftsPoint2;
}

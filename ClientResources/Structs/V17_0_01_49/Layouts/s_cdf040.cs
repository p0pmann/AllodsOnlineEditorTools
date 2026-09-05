// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(81)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_cdf040
{
    [FieldOffset(8)] public string @endBone;
    [FieldOffset(32)] public float @radiusCoefficientEnd;
    [FieldOffset(36)] public float @radiusCoefficientStart;
    [FieldOffset(40)] public float @radiusX;
    [FieldOffset(44)] public float @radiusY;
    [FieldOffset(48)] public float @radiusZ;
    [FieldOffset(56)] public string @startBone;
    [FieldOffset(80)] public bool @notShowInDEBUG;
}

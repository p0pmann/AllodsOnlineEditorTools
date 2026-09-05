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

[StructSize(56)]
[XdbName("VisualSettings")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisualSettings
{
    [FieldOffset(36)] public float @FogCoeff;
    [FieldOffset(40)] public int @FogColor;
    [FieldOffset(44)] public float @FogEnd;
    [FieldOffset(48)] public float @FogStart;
}

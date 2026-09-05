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

[SerializedExtent(105)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17c4ff0
{
    [FieldOffset(4)] public int @angleInDegrees;
    [FieldOffset(8)] public Layouts.@s_17c1da0 @cylinder;
    [FieldOffset(80)] public Vector2 @frontDirection;
    [FieldOffset(88)] public int @iCount;
    [FieldOffset(92)] public int @jCount;
    [FieldOffset(96)] public float @startZCoeff;
    [FieldOffset(100)] public float @surfaceLength;
    [FieldOffset(104)] public bool @use;
}

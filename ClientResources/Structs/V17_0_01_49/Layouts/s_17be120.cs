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

[SerializedExtent(44)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_17be120
{
    [FieldOffset(4)] public float @deltaT;
    [FieldOffset(8)] public Vector3 @rotation;
    [FieldOffset(20)] public Vector3 @translation;
    [FieldOffset(32)] public Vector3 @velocity;
}

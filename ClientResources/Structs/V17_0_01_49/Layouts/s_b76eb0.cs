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

[SerializedExtent(64)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_b76eb0
{
    [FieldOffset(8)] public string @name;
    [FieldOffset(32)] public Vector3 @position;
    [FieldOffset(44)] public Quaternion @rotation;
    [FieldOffset(60)] public float @scale;
}

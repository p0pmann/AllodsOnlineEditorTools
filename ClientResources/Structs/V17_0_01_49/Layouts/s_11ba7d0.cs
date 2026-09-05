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

[SerializedExtent(34)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11ba7d0
{
    [FieldOffset(8)] public ResourcePointer @flyingVisObject;
    [FieldOffset(16)][EnumRef(typeof(Enums.@e_11ba890))] public int @mode;
    [FieldOffset(24)] public ResourcePointer @nodeVisObject;
    [FieldOffset(32)] public bool @rotateFlyingXY;
    [FieldOffset(33)] public bool @rotateNodeXY;
}

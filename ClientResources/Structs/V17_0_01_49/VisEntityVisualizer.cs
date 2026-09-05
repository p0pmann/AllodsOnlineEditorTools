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

[SerializedExtent(108)]
[XdbName("VisEntityVisualizer")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisEntityVisualizer
{
    [FieldOffset(48)] public ResourcePointer @collision;
    [FieldOffset(56, ArrayStride = 32)] public Layouts.@s_1a816c0[] @matches;
    [FieldOffset(88)] public float @scale;
    [FieldOffset(96)] public ResourcePointer @visObj;
    [FieldOffset(104)] public bool @collisionObject;
    [FieldOffset(105)] public bool @interactiveObject;
    [FieldOffset(106)] public bool @matchShipSkin;
    [FieldOffset(107)] public bool @useDelayedCollision;
}

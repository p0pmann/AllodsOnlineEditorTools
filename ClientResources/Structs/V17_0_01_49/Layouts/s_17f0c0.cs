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
public partial class @s_17f0c0
{
    [FieldOffset(4)] public float @delay;
    [FieldOffset(8)] public int @endFrame;
    [FieldOffset(12)] public float @lifetime;
    [FieldOffset(16)] public float @speed;
    [FieldOffset(20)] public int @startFrame;
    [FieldOffset(24)] public ResourcePointer @textureAtlas;
    [FieldOffset(32)] public bool @loop;
    [FieldOffset(33)] public bool @useRandomFrame;
}

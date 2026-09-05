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

[SerializedExtent(56)]
[XdbName("EffectOffendConstVelocity")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @EffectOffendConstVelocity
{
    [FieldOffset(44)] public int @delay;
    [FieldOffset(48)] public float @maxDist;
    [FieldOffset(52)] public float @velocity;
}

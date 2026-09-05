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

[StructSize(80)]
[XdbName("gameMechanics.map.tour.Route")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @Route
{
    [FieldOffset(40, ArrayStride = 40)] public Layouts.@s_15e85e0[] @points;
    [FieldOffset(72)] public bool @dropAtEnd;
    [FieldOffset(73)] public bool @isClosed;
    [FieldOffset(74)] public bool @showEndFog;
    [FieldOffset(75)] public bool @showStartFog;
}

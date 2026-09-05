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

[SerializedExtent(169)]
[XdbName("ShipEngineComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ShipEngineComponent
{
    [FieldOffset(48, ArrayStride = 24)] public Layouts.@s_17f7500[] @angularVelocityScripts;
    [FieldOffset(80)] public Layouts.@s_a96d80 @engineSound;
    [FieldOffset(120)] public NullablePointer @inHangarScript;
    [FieldOffset(128)] public NullablePointer @onIslandScript;
    [FieldOffset(136, ArrayStride = 24)] public Layouts.@s_17f7500[] @velocityScripts;
    [FieldOffset(168)] public bool @useTargetSpeed;
}

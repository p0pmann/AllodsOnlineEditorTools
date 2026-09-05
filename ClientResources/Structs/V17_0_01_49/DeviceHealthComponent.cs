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

[SerializedExtent(81)]
[XdbName("DeviceHealthComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceHealthComponent
{
    [FieldOffset(48, ArrayStride = 16)] public Layouts.@s_17f2180[] @states;
    [FieldOffset(80)] public bool @useParentState;
}

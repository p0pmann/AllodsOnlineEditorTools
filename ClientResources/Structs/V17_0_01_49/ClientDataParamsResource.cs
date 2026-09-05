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

[SerializedExtent(104)]
[XdbName("gameMechanics.world.ClientDataParamsResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ClientDataParamsResource
{
    [FieldOffset(40, ArrayStride = 40)] public Layouts.@s_15551d0[] @paramViewTypes;
    [FieldOffset(72, ArrayStride = 40)] public Layouts.@s_1555150[] @params;
}

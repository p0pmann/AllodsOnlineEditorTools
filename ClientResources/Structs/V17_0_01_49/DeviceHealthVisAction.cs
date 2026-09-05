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

[SerializedExtent(113)]
[XdbName("DeviceHealthVisAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @DeviceHealthVisAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(80, ArrayStride = 24)] public Layouts.@s_18f9bb0[] @actions;
    [FieldOffset(112)] public bool @useParentState;
}

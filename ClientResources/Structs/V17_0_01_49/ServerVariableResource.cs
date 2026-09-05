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

[StructSize(56)]
[XdbName("gameMechanics.constructor.basicElements.ServerVariableResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ServerVariableResource
{
    [FieldOffset(40)] public long @defaultValue;
    [FieldOffset(48)] public bool @replicateClient;
}

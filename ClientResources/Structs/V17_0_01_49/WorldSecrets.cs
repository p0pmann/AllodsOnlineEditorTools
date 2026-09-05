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

[StructSize(72)]
[XdbName("gameMechanics.constructor.schemes.quest.WorldSecrets")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @WorldSecrets
{
    [FieldOffset(40, ArrayStride = 56)] public Layouts.@s_1634a00[] @secrets;
}

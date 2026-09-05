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

[StructSize(96)]
[XdbName("gameMechanics.constructor.schemes.unlock.UnlockCategoryResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @UnlockCategoryResource
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)] public string @sysName;
}

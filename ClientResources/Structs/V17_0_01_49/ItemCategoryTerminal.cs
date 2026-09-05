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

[StructSize(120)]
[XdbName("gameMechanics.constructor.schemes.item.ItemCategoryTerminal")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ItemCategoryTerminal
{
    [FieldOffset(40)] public TextFileRef @name;
    [FieldOffset(72)] public string @sysName;
    [FieldOffset(96)] public bool @showAuction;
    [FieldOffset(112)] public NullablePointer @condition;
}

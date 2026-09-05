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

[StructSize(136)]
[XdbName("gameMechanics.elements.skills.forge.ForgeCraftResource")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ForgeCraftResource
{
    [FieldOffset(40, ArrayStride = 8)] public NullablePointer[] @available;
    [FieldOffset(72)] public TextFileRef @name;
    [FieldOffset(104, ArrayStride = 8)] public ResourcePointer[] @recipes;
}

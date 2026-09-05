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

[SerializedExtent(112)]
[XdbName("gameMechanics.elements.resources.ResourceIf")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceIf
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(64, ArrayStride = 8)] public NullablePointer[] @predicates;
    [FieldOffset(96)] public NullablePointer @resourceElse;
    [FieldOffset(104)] public NullablePointer @resourceIf;
}

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

[SerializedExtent(105)]
[XdbName("PredicateAvatarClassAction")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @PredicateAvatarClassAction
{
    [FieldOffset(40)] public string @visActionID;
    [FieldOffset(72, ArrayStride = 8)] public ResourcePointer[] @classes;
    [FieldOffset(104)] public bool @checkIsClass;
}

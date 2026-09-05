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

[SerializedExtent(82)]
[XdbName("IfVisualMount")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @IfVisualMount
{
    [FieldOffset(48, ArrayStride = 8)] public ResourcePointer[] @mountsList;
    [FieldOffset(80)] public bool @checkIsInTheList;
    [FieldOffset(81)] public bool @checkOnStartOnly;
}

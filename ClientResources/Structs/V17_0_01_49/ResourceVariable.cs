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

[SerializedExtent(88)]
[XdbName("gameMechanics.elements.resources.ResourceVariable")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ResourceVariable
{
    [FieldOffset(44)] public bool @hideText;
    [FieldOffset(64)] public ResourcePointer @ability;
    [FieldOffset(72)] public ResourcePointer @variable;
    [FieldOffset(84)] public float @sub;
}

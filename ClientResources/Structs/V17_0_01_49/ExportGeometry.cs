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

[StructSize(48)]
[XdbName("ExportGeometry")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @ExportGeometry
{
    [FieldOffset(36)] public bool @decalModel;
    [FieldOffset(37)] public bool @exportDefaultAnimation;
    [FieldOffset(38)] public bool @largeModel;
    [FieldOffset(39)] public bool @lodModel;
    [FieldOffset(40)] public bool @portalModel;
    [FieldOffset(41)] public bool @useProceduralEffect;
}

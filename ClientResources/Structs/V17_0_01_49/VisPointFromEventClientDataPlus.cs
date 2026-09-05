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

[SerializedExtent(81)]
[XdbName("VisPointFromEventClientDataPlus")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @VisPointFromEventClientDataPlus
{
    [FieldOffset(36)] public Vector3 @shift;
    [FieldOffset(52)] public int @index;
    [FieldOffset(56)] public string @locatorName;
    [FieldOffset(80)] public bool @fromTarget;
}

// Generated from client serializer evidence. Regenerate with EditorCLI generate structs.
// ReSharper disable InconsistentNaming
#nullable disable
using System.Numerics;
using AllodsOnlineEditorTools.ClientResources.DataTypes;
using AllodsOnlineEditorTools.ClientResources.Serialization;
using AllodsOnlineEditorTools.ClientResources.Serialization.Bin;
using AllodsOnlineEditorTools.ClientResources.Serialization.Xdb;
using JetBrains.Annotations;

namespace AllodsOnlineEditorTools.ClientResources.Structs.V17_0_01_49.Layouts;

[SerializedExtent(41)]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @s_11d2e70
{
    [FieldOffset(4)] public BigVector3 @position;
    [FieldOffset(28)] public float @radius;
    [FieldOffset(32)] public ResourcePointer @zone;
    [FieldOffset(40)] public bool @isIndoor;
}

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

[SerializedExtent(152)]
[XdbName("SunShaftsComponent")]
[UsedImplicitly(ImplicitUseTargetFlags.WithMembers)]
public partial class @SunShaftsComponent
{
    [FieldOffset(40)] public string @VisualObjectComponentID;
    [FieldOffset(72)] public string @materialBindName;
    [FieldOffset(96)] public string @pivotName;
    [FieldOffset(120)] public string @slotName;
    [FieldOffset(144)] public ResourcePointer @sunShafts;
}
